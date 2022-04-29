import json
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

f = open("json/players.json", "w")
active_players = players.get_active_players()
allplayerinfo = []
try:
    for p in active_players:
        playerinfo = CommonPlayerInfo(player_id=p['id']).common_player_info
        allplayerinfo.append(dict(zip(playerinfo.data['headers'], playerinfo.data['data'])))
finally:
    f.write(json.dumps(allplayerinfo))
    f.close()