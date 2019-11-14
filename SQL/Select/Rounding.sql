SELECT *, 
    A * CAST(B AS FLOAT) res_cast,
    ROUND(A * CAST(B AS FLOAT), 2) res_cast_round,
    CAST(A as DECIMAL(10, 6)) * CAST(B as DECIMAL(10, 6)) res,
    ROUND(CAST(A as DECIMAL(10, 6)) * CAST(B as DECIMAL(10, 6)), 2) res_round
FROM TMP

--https://pt.stackoverflow.com/q/106870/101
