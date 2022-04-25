DROP PROCEDURE [dbo].[prcInsertGames]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[prcInsertGames]
(@json VARCHAR(MAX) = '')
AS
BEGIN

SET IDENTITY_INSERT NBA.Game ON

INSERT INTO NBA.Game (GameId, HomeTeamId, AwayTeamId, SeasonScheduleId, [Date])
SELECT GameId, HomeTeamId, AwayTeamId, SeasonScheduleId, [Date]
	FROM OPENJSON(@json)
	WITH (
		GameId INT '$.id',
		HomeTeamId INT '$.teams.home.id',
		AwayTeamId INT '$.teams.visitors.id',
        SeasonScheduleId INT '$.season',
        [Date] DATETIMEOFFSET '$.date.start'
	    )
END
GO

DROP PROCEDURE [dbo].[prcInsertTeams]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[prcInsertTeams]
(@json VARCHAR(MAX) = '')
AS
BEGIN

SET IDENTITY_INSERT NBA.Team ON

INSERT INTO NBA.Team (TeamId, StadiumId, TeamName, YearFounded)
SELECT TeamId, 1, TeamName, 2021
	FROM OPENJSON(@json)
	WITH (
		TeamId INT '$.id',
		TeamName NVARCHAR(32) '$.name'
	    )
END
GO
