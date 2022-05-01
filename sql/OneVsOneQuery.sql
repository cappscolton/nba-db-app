DECLARE @PlayerId1 INT;
DECLARE @PlayerId2 INT;

SET @PlayerId1 = 1629680
SET @PlayerId2 = 1629109

SELECT PlayerId, AVG(PointsScored) FROM NBA.GameTeamPlayer GTP
WHERE GTP.GameId IN
    (
    SELECT GameId FROM NBA.GameTeamPlayer
    WHERE PlayerId = @PlayerId1
    INTERSECT
    SELECT GameId FROM NBA.GameTeamPlayer
    WHERE PlayerId = @PlayerId2
    )
AND (GTP.PlayerId=@PlayerId1 OR GTP.PlayerId=@PlayerId2)
GROUP BY PlayerId