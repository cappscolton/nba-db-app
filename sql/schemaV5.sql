CREATE SCHEMA NBA
GO
CREATE TABLE NBA.Location
(
    LocationId INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    StadiumName VARCHAR(128) NOT NULL,
    City VARCHAR(32) NOT NULL,
    State VARCHAR(16) NOT NULL,
    ZipCode INT NOT NULL
);

CREATE TABLE NBA.Team
(
    TeamId INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    StadiumId INT NOT NULL FOREIGN KEY REFERENCES NBA.Location(LocationId),
    TeamName NVARCHAR(32) NOT NULL UNIQUE,
    TeamAbbreviation NVARCHAR(8) NOT NULL UNIQUE,
    YearFounded INT NOT NULL

    UNIQUE
    (
        TeamName
    )
);

CREATE TABLE NBA.SeasonSchedule
(
    SeasonScheduleId INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    SeasonYear NVARCHAR(16) NOT NULL,
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

CREATE TABLE NBA.Player
(
    PlayerId INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    FirstName VARCHAR(32) NOT NULL,
    LastName VARCHAR(32) NOT NULL,
    CurrentTeam VARCHAR(32) NOT NULL,
    Position VARCHAR(16) NOT NULL
);

CREATE TABLE NBA.GameTeamPlayer
(
    GameTeamPlayerId INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    TeamId INT NOT NULL FOREIGN KEY REFERENCES NBA.Team(TeamId),
    GameId INT NOT NULL FOREIGN KEY REFERENCES NBA.Game(GameId),
    PlayerId INT NOT NULL FOREIGN KEY REFERENCES NBA.Player(Playerid),
    PointsScored INT NOT NULL,
    PlusMinus INT NOT NULL,
    [Minutes] DECIMAL NOT NULL,
    FGM INT NOT NULL,
    FGA INT NOT NULL,
    FG3M INT NOT NULL,
    FG3A INT NOT NULL,
    FTM INT NOT NULL,
    FTA INT NOT NULL,
    OREB INT NOT NULL,
    DREB INT NOT NULL,
    Assists INT NOT NULL,
    Turnovers INT NOT NULL,
    Blocks INT NOT NULL,
    Fouls INT NOT NULL
);

INSERT INTO NBA.Location(StadiumName, City, [State], ZipCode) VALUES 
('State Farm Arena', 'Atlanta', 'GA', '30303'),
('TD Garden', 'Boston', 'MA', '02114'),
('Rocket Mortgage FieldHouse', 'Cleveland', 'OH', '44115'),
('Smoothie King Center', 'New Orleans', 'LA', '70113'),
('United Center', 'Chicago', 'IL', '60612'),
('American Airlines Center', 'Dallas', 'TX', '75219'),
('Ball Arena', 'Denver', 'CO', '80204'),
('Chase Center', 'San Francisco', 'CA', '94158'),
('Toyota Center', 'Houston', 'TX', '77003'),
('Crypto.com Arena', 'Los Angeles', 'CA', '90015'),
('Crypto.com Arena', 'Los Angeles', 'CA', '90015'),
('FTX Arena', 'Miami', 'FL', '33132'),
('Fiserv Forum', 'Milwaukee', 'WI', '53203'),
('Target Center', 'Minneapolis', 'MN', '55403'),
('Barclays Center', 'Brooklyn', 'NY', '11217'),
('Madison Square Garden','New York', 'NY', '10001'),
('Amway Center', 'Orlando', 'FL', '32801'),
('Gainbridge Fieldhouse', 'Indianapolis', 'IN', '46204'),
('Wells Fargo Center', 'Philadelphia', 'PA', '19148'),
('Footprint Center', 'Phoenix', 'AZ', '85004'),
('Moda Center', 'Portland', 'OR', '97227'),
('Golden 1 Center', 'Sacramento', 'CA', '95814'),
('AT&T Center', 'San Antonio', 'TX', '78219'),
('Paycom Center', 'Oklahoma City', 'OK', '73102'),
('Scotiabank Arena', 'Toronto', 'ON', '11111'),
('Vivint Arena', 'Salt Lake City', 'UT', '84101'),
('FedExForum', 'Memphis', 'TN', '38103'),
('Capital One Arena', 'Washington', 'DC', '20004'),
('Little Caesars Arena', 'Detroit', 'MI', '48201'),
('Spectrum Center', 'Charlotte', 'NC', '28202')