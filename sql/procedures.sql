CREATE OR ALTER Procedure [dbo].[prcInsertGames]
(@json VARCHAR(MAX) = '')
AS
BEGIN
SET IDENTITY_INSERT NBA.Game ON
INSERT INTO NBA.Game (GameId, HomeTeamId, AwayTeamId, SeasonScheduleId, [Date])
SELECT GameId, HomeTeamId, AwayTeamId, 1, [Date]
	FROM OPENJSON(@json)
	WITH (
		GameId INT '$.gameId',
		HomeTeamId INT '$.homeTeamId',
		AwayTeamId INT '$.awayTeamId',
        SeasonScheduleId INT '$.seasonId',
        [Date] DATETIMEOFFSET '$.gameDate'
	    )
END
GO


CREATE OR ALTER Procedure [dbo].[prcInsertTeams]
(@json VARCHAR(MAX) = '')
AS
BEGIN
SET IDENTITY_INSERT NBA.Team ON
INSERT INTO NBA.Team (TeamId, StadiumId, TeamName, YearFounded, TeamAbbreviation)
SELECT TeamId, 1, TeamName, YearFounded, TeamAbbreviation
	FROM OPENJSON(@json)
	WITH (
		TeamId INT '$.id',
		TeamName NVARCHAR(32) '$.full_name',
		YearFounded INT '$.year_founded',
		TeamAbbreviation NVARCHAR(8) '$.abbreviation'
	    )
END
GO


CREATE OR ALTER Procedure [dbo].[prcInsertGameTeamPlayers]
(@json VARCHAR(MAX) = '')
AS
BEGIN
SET IDENTITY_INSERT NBA.GameTeamPlayer OFF
INSERT INTO NBA.GameTeamPlayer (TeamId, GameId, PlayerId, PointsScored)
SELECT TeamId, GameId, PlayerId, PointsScored
	FROM OPENJSON(@json)
	WITH (
		TeamId INT '$.TEAM_ID',
		GameId NVARCHAR(32) '$.GAME_ID',
        PlayerId NVARCHAR(32) '$.PLAYER_ID',
        PointsScored INT '$.PTS'
	    )
END
GO


CREATE OR ALTER Procedure [dbo].[prcInsertPlayers]
(@json VARCHAR(MAX) = '')
AS
BEGIN
SET IDENTITY_INSERT NBA.Player ON
INSERT INTO NBA.Player (PlayerId, FirstName, LastName, YearsPlayed, JerseyNumber)
SELECT PlayerId, FirstName, LastName, 0, JerseyNumber
	FROM OPENJSON(@json)
	WITH (
		PlayerId INT '$.PERSON_ID',
		FirstName NVARCHAR(32) '$.FIRST_NAME',
        LastName NVARCHAR(32) '$.LAST_NAME',
		JerseyNumber INT '$.JERSEY' -- todo
	    )
END
GO




