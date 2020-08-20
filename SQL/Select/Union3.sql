SELECT * FROM noticias WHERE destaque = 1 limit 5
UNION ALL
SELECT * FROM noticias WHERE destaque <> 1 limit 25

--https://pt.stackoverflow.com/q/352746/101
