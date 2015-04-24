WITH Numbers (Value) AS
( 
	SELECT 1 
	UNION ALL
	SELECT Value + 1
	FROM Numbers
)

SELECT TOP(100) 
	Value
	,CONCAT(
		CASE WHEN Value % 3 = 0 THEN 'Fizz' ELSE NULL END,  
		CASE WHEN Value % 5 = 0 THEN 'Buzz' ELSE NULL END
	)
FROM Numbers