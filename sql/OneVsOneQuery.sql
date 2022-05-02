DECLARE @PlayerId1 INT;
DECLARE @PlayerId2 INT;

SET @PlayerId1 = 1629680
SET @PlayerId2 = 1629109

SELECT FirstName, LastName, AVG(PointsScored) AS AveragePoints, AVG([Minutes]) AS AverageMinutes FROM NBA.GameTeamPlayer GTP
INNER JOIN NBA.Player P ON P.PlayerId = GTP.PlayerId
WHERE GTP.GameId IN
    (
    SELECT GameId FROM NBA.GameTeamPlayer
    WHERE GTP.PlayerId = @PlayerId1
    INTERSECT
    SELECT GameId FROM NBA.GameTeamPlayer
    WHERE GTP.PlayerId = @PlayerId2
    )
AND (GTP.PlayerId=@PlayerId1 OR GTP.PlayerId=@PlayerId2)
GROUP BY GTP.PlayerId