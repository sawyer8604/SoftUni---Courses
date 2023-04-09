SELECT*
FROM Users u
JOIN UsersGames AS ug ON ug.UserId = u.Id
JOIN Games AS g ON g.Id = ug.GameId
WHERE g.Name = 'Bali' AND u.Username IN('baleremuda', 'loosenoise', 'inguinalself', 'buildingdeltoid', 'monoxidecos')

---50 000
UPDATE UsersGames
SET Cash += 50000
	WHERE  GameId = (SELECT Id FROM Games WHERE Name = 'Bali') AND 
		   UserId IN (SELECT Id FROM Users WHERE Username IN('baleremuda', 'loosenoise', 'inguinalself', 'buildingdeltoid', 'monoxidecos'))
