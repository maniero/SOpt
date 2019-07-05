REVOKE ALL PRIVILEGES, GRANT OPTION FROM usuario1, usuario2

REVOKE ALL PRIVILEGES ON banco.* FROM usuario1, usuario2

SHOW GRANTS FOR usuario

SHOW GRANTS FOR '%'@'%'

SELECT sql_grants FROM common_schema.sql_show_grants

REVOKE ALL PRIVILEGES ON banco.* FROM '%'@'%'

GRANT USAGE ON banco.* TO 'usuario'@'%'

--https://pt.stackoverflow.com/q/49851/101
