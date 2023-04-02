SELECT COUNT(c.CountryCode)
	
FROM Countries As c
LEFT JOIN MountainsCountries mc ON c.CountryCode = mc.CountryCode
WHERE mc.MountainId IS NULL

