import json
from multiprocessing.connection import wait
from nba_api.stats.static import players
from nba_api.stats.static import teams
from nba_api.stats.endpoints import PlayerGameLogs
from nba_api.stats.endpoints import LeagueGameLog
from nba_api.stats.library.parameters import LeagueID
from nba_api.stats.endpoints import CommonPlayerInfo

class Game:
    def __init__(self, seasonId, homeTeamId, awayTeamId, homeTeamAbbr, awayTeamAbbr,
                 gameId, gameDate, homeTeamScore, awayTeamScore):
        self.seasonId = int(seasonId)
        self.homeTeamId = homeTeamId
        self.awayTeamId = awayTeamId
        self.homeTeamAbbr = homeTeamAbbr
        self.awayTeamAbbr = awayTeamAbbr
        self.gameId = int(gameId)
        self.gameDate = gameDate
        self.homeTeamScore = homeTeamScore
        self.awayTeamScore = awayTeamScore
    def __eq__(self, other):
        return self.gameId == other.gameId
        
def getGames(year):
    f = open('json/games.json', 'w')
    allSeasonGames = []
    for season in [year]:#['2020-21', '2021-22']:
        x = LeagueGameLog(league_id=LeagueID.nba, season=season)
        keys = x.league_game_log.data['headers']
        values = x.league_game_log.data['data']
        jsonified = []
        for i in values:
            jsonified.append(dict(zip(keys, i)))
        combined_matchups = []
        for team1 in jsonified:
            for team2 in jsonified:
                if team1["GAME_ID"] == team2["GAME_ID"] and team1["TEAM_ID"] != team2["TEAM_ID"]:
                    homeTeam, awayTeam = (team2, team1) if ('@' in team1["MATCHUP"]) else (team1, team2)
                    game = Game(team1['SEASON_ID'],homeTeam['TEAM_ID'],awayTeam['TEAM_ID'],homeTeam['TEAM_ABBREVIATION'], 
                        awayTeam['TEAM_ABBREVIATION'], homeTeam["GAME_ID"], homeTeam['GAME_DATE'],homeTeam['PTS'],  awayTeam['PTS'])
                    if game not in combined_matchups: combined_matchups.append(game)
                    break
        allSeasonGames += combined_matchups
    f.write(json.dumps(allSeasonGames, default=vars))
    f.close()

def getTeamPlayerGames(year):
    f = open("json/teamplayergames.json", "w")
    allSeasonsTeamPlayerGames = []
    for season in year:#['2020-21', '2021-22']:
        x = PlayerGameLogs(season_nullable=season, league_id_nullable=LeagueID.nba)
        keys = x.player_game_logs.data['headers']
        values = x.player_game_logs.data['data']

        jsonified = []
        for i in values:
            jsonified.append(dict(zip(keys, i)))
        allSeasonsTeamPlayerGames += jsonified

    f.write(json.dumps(jsonified))
    f.close()

def getTeams():
    f = open("json/teams.json", "w")
    f.write(json.dumps(teams.get_teams()))
    f.close()

# def getPlayers():
#     f = open("json/players.json", "a")
#     active_players = players.get_active_players()
#     lastPlayerId = 1627826
#     begin = False
#     allPlayerInfo = []
#     for p in active_players:
#         if p['id'] != lastPlayerId and begin is False: continue
#         if p['id'] == lastPlayerId:
#             begin = True
#             continue
#         if begin:
#             try:
#                 playerInfo = CommonPlayerInfo(player_id=p['id']).common_player_info
#                 playerInfoDict = dict(zip(playerInfo.data['headers'], playerInfo.data['data'][0]))
#                 lastPlayerId = playerInfoDict['PERSON_ID']
#                 allPlayerInfo.append(playerInfoDict)
#             except Exception:
#                 f.write(json.dumps(allPlayerInfo))
#                 f.close()
#             finally:
#                 print(lastPlayerId)

#     f.write(json.dumps(allPlayerInfo))
#     print(lastPlayerId)
#     f.close()
# getPlayers()
  
def lookupAnomalyPlayers():
    playerData = ""
    with open("json/players.json", 'r') as file:
        playerData = file.read().replace('\n', '')
        playersList = [x['PERSON_ID'] for x in json.loads(playerData)]
    with open("json/teamplayergames.json", 'r') as file:
        playerGamesData = file.read().replace('\n', '')
        playerGamesSet = set([x['PLAYER_ID'] for x in json.loads(playerGamesData)])
    anomalies = []
    for playerId in playerGamesSet:
        if playerId not in playersList:
            anomalies.append(playerId)
    
    if len(anomalies) > 0: print("added anomaly player data, fix players.json json brackets manually")
    f = open("json/players.json", "a") # fix the file manually since there will be an extra json bracket after appending
    for i in anomalies:
        playerInfo = CommonPlayerInfo(player_id=i).common_player_info
        playerInfoDict = dict(zip(playerInfo.data['headers'], playerInfo.data['data'][0]))
        f.write(json.dumps(playerInfoDict))
    f.close()

#getTeams()
#getGames(['2019-20'])  
#getTeamPlayerGames(['2019-20'])
lookupAnomalyPlayers()
