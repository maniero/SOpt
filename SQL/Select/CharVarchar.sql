SELECT pg_column_size(CHAR(11) '999999999'), pg_column_size(VARCHAR(11) '999999999'), pg_column_size(NUMERIC(9,0) '999999999');

--https://pt.stackoverflow.com/q/240751/101
