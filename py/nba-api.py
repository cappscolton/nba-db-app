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
        

f = open('json/games.json', 'w')
x = LeagueGameLog(league_id=LeagueID.nba, season='2021-22')
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
f.write(json.dumps(combined_matchups, default=vars))
f.close()

f = open("json/teamplayergames.json", "w")
x = PlayerGameLogs(season_nullable='2021-22', league_id_nullable=LeagueID.nba)
keys = x.player_game_logs.data['headers']
values = x.player_game_logs.data['data']

jsonified = []
for i in values:
    jsonified.append(dict(zip(keys, i)))

f.write(json.dumps(jsonified))
f.close()

f = open("json/teams.json", "w")
f.write(json.dumps(teams.get_teams()))
f.close()

f = open("json/players.json", "a")
active_players = players.get_active_players()
lastPlayerId = 1627826
begin = False
allPlayerInfo = []
for p in active_players:
    if p['id'] != lastPlayerId and begin is False: continue
    if p['id'] == lastPlayerId:
        begin = True
        continue
    if begin:
        try:
            playerInfo = CommonPlayerInfo(player_id=p['id']).common_player_info
            playerInfoDict = dict(zip(playerInfo.data['headers'], playerInfo.data['data'][0]))
            lastPlayerId = playerInfoDict['PERSON_ID']
            allPlayerInfo.append(playerInfoDict)
        except Exception:
            f.write(json.dumps(allPlayerInfo))
            f.close()
        finally:
            print(lastPlayerId)

f.write(json.dumps(allPlayerInfo))
print(lastPlayerId)
f.close()


f = open("json/players.json", "a")
anomalies = [1630222, 1626144, 1626147, 1628221, 1630278, 1630285, 1628238, 1630286, 1630296, 1630314, 1630322, 2207, 202954, 1628382, 1628422, 1628436, 1628537, 1628591, 1630758, 1630787, 1630792, 1630846, 203516, 1630994, 101139, 1628982, 1629005, 1629035, 203658, 1629109, 1629164, 1629168, 1629203, 203816, 1629309, 1629312, 203917, 201954, 204020, 204025, 202083, 1629600, 1629610, 1629619, 1629623, 1629658, 1629683, 1629686, 1629718, 1629730, 1629751, 1629760, 202326, 202328, 202334, 1629788, 1627760, 1627767, 202362, 1627820, 1629873, 1629875, 1629958, 1629962, 1628035, 202687, 202688, 202738]
for i in anomalies:
    playerInfo = CommonPlayerInfo(player_id=i).common_player_info
    playerInfoDict = dict(zip(playerInfo.data['headers'], playerInfo.data['data'][0]))
    f.write(json.dumps(playerInfoDict))
f.close()
