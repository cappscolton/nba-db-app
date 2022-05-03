SELECT FirstName, LastName, Stats * 1.00000 / CONVERT(DECIMAL(10,5), TotalMinutes) AS LinearPER FROM 
    (
        SELECT * FROM 
        (
            SELECT P.FirstName, P.LastName, 
            SUM(GTP.FGM) * 85.910 + 
            SUM(Steals) *  53.897 
            + SUM(FG3M) * 51.757 
            + SUM(FTM) * 46.845 
            + SUM(BLOCKS) * 39.190
            + SUM(OREB) * 39.190 
            + SUM(Assists) * 34.677 
            + SUM(DREB) * 14.707 
            - SUM(Fouls) * 17.174 
            - SUM(FTA-FTM) * 20.091 
            - SUM(FGA-FGM) * 39.190 
            - SUM(Turnovers) * 53.897 AS Stats, 
            SUM([Minutes]) AS TotalMinnutes FROM NBA.GameTeamPlayer GTP
            INNER JOIN NBA.Player P ON P.PlayerId = GTP.PlayerId
            INNER JOIN NBA.Game G ON GTP.GameId = G.GameId
            WHERE G.SeasonScheduleId = '22019'
            GROUP BY P.FirstName, P.LastName
        ) AS MyTable (FirstName, LastName, Stats, TotalMinutes)
        WHERE TotalMinutes > 20

    ) AS FilteredPlayers
ORDER BY LinearPER DESC
-- [ FGM x 85.910

-- + Steals x 53.897

-- + 3PTM x 51.757

-- + FTM x 46.845

-- + Blocks x 39.190

-- + Offensive_Reb x 39.190

-- + Assists x 34.677

-- + Defensive_Reb x 14.707

-- - Foul x 17.174

-- - FT_Miss x 20.091

-- - FG_Miss x 39.190

-- - TO x 53.897 ]

-- x (1 / Minutes).