SELECT mc.[CountryCode] , Count (m.MountainRange)

FROM MountainsCountries AS mc
	JOIN Mountains AS m ON  mc.MountainId = m.ID 
WHERE mc.CountryCode IN('US', 'BG', 'RU')
GRoup BY mc.[CountryCode]

