SELECT u.Username, g.Name, ug.Cash, i.Name
FROM Users AS u 
JOIN UsersGames AS ug ON ug.UserId = u.Id
JOIN Games AS g ON g.Id = ug.GameId
JOIN UserGameItems AS ugi ON ugi.UserGameId = ug.Id
JOIN Items AS i ON i.Id = ugi.ItemId
WHERE g.Name = 'Bali'
ORDER BY u.Username, i.Name