DECLARE @PlayerId INT;

SELECT FirstName, LastName, SUM(PlusMinus) SumPlusMinus FROM NBA.GameTeamPlayer GTP
INNER JOIN NBA.Player P ON P.PlayerId = GTP.PlayerId
GROUP BY GTP.PlayerId, FirstName, LastName
ORDER BY SumPlusMinus DESC