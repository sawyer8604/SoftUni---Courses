SELECT TOP(5) c.CountryName, r.RiverName

FROM CountriesRivers AS mr
	FULL JOIN Countries AS c ON  c.CountryCode = mr.CountryCode 
	FULL JOIN Rivers AS r ON  r.Id = mr.RiverId 
	WHERE c.ContinentCode = 'AF'
ORDER BY c.CountryName ASC

