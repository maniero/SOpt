select concat('KILL ',id,';') from information_schema.processlist where user='root' into outfile '/tmp/a.txt';

SELECT GROUP_CONCAT(CONCAT('KILL QUERY ',id,';') SEPARATOR ' ') KillQuery
FROM information_schema.processlist WHERE user<>'system user'\G


mysql -NBe "SELECT CONCAT('KILL ', id, ';') FROM information_schema.processlist WHERE user = 'some_username';" | mysql -vv

//https://pt.stackoverflow.com/q/85450/101
