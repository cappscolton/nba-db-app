CREATE SCHEMA NBA;
GO
CREATE TABLE NBA.Location
(
    LocationId INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    StadiumName VARCHAR(128) NOT NULL,
    City VARCHAR(32) NOT NULL,
    State VARCHAR(16) NOT NULL,
    ZipCode INT NOT NULL

    UNIQUE
    (
        StadiumName
    )
);

CREATE TABLE NBA.Team
(
    TeamId INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    StadiumId INT NOT NULL FOREIGN KEY REFERENCES NBA.Location(LocationId),
    TeamName NVARCHAR(32) NOT NULL,
    YearFounded INT NOT NULL

    UNIQUE
    (
        TeamName
    )
);

CREATE TABLE NBA.SeasonSchedule
(
    SeasonScheduleId INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    SeasonStartDate DATETIMEOFFSET NOT NULL,
    SeasonEndDate DATETIMEOFFSET NOT NULL

    UNIQUE
    (
        SeasonStartDate,
        SeasonEndDate
    )
);

CREATE TABLE NBA.TeamSeasonSchedule
(
    SeasonScheduleId INT NOT NULL FOREIGN KEY REFERENCES NBA.SeasonSchedule(SeasonScheduleId),
    TeamId INT NOT NULL FOREIGN KEY REFERENCES NBA.Team(TeamId)
    PRIMARY KEY
    (
        SeasonScheduleId,
        TeamId
    )
);

CREATE TABLE NBA.Game
(
   GameId INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
   HomeTeamId INT NOT NULL FOREIGN KEY REFERENCES NBA.Team(TeamId),
   AwayTeamId INT NOT NULL FOREIGN KEY REFERENCES NBA.Team(TeamId),
   SeasonScheduleId INT NOT NULL FOREIGN KEY REFERENCES NBA.SeasonSchedule(SeasonScheduleId),
   [Date] DATETIMEOFFSET NOT NULL
);

CREATE TABLE NBA.GameTeamPlayer
(
    GameTeamPlayerId INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    TeamId INT NOT NULL FOREIGN KEY REFERENCES NBA.Team(TeamId),
    GameId INT NOT NULL FOREIGN KEY REFERENCES NBA.Game(GameId),
    PointsScored INT NOT NULL,
    FirstName VARCHAR(32) NOT NULL,
    LastName VARCHAR(32) NOT NULL,
    YearsPlayed INT NOT NULL,
    JerseyNumber INT NOT NULL
);