mysql -Nse 'show tables' DATABASE_NAME | while read table; do mysql -e "truncate table $table" DATABASE_NAME; done

Ou através de comando SQL:

SELECT Concat('TRUNCATE TABLE ', table_schema, '.', table_name, ';') 
    FROM INFORMATION_SCHEMA.TABLES where table_schema in ('seuDB'); //pode listar vários DBs

Dá para fazer vários filtros:

SELECT Concat('TRUNCATE TABLE ', table_schema, '.', table_name, ';') 
    FROM INFORMATION_SCHEMA.TABLES where table_schema in ('seuDB') AND table_name NOT IN ('tabela1', 'tabela2', ...);
    
--https://pt.stackoverflow.com/q/53782/101
