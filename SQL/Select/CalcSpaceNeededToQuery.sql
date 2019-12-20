SELECT pg_database.datname, pg_database_size(pg_database.datname),
    pg_size_pretty(pg_database_size(pg_database.datname))
FROM pg_database ORDER BY pg_database_size DESC

--https://pt.stackoverflow.com/q/122262/101
