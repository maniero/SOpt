CREATE TABLE ValueTable (id int);  
BEGIN TRANSACTION;              -- aqui começa a transação
       INSERT INTO ValueTable VALUES(1);  
       INSERT INTO ValueTable VALUES(2);  
COMMIT;                         -- aqui termina e "grava" tudo

--https://pt.stackoverflow.com/q/203669/101
