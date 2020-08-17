(SELECT administradores_id FROM adm LIMIT 1)
UNION
SELECT usuarios_id FROM user;

--https://pt.stackoverflow.com/q/345177/101
