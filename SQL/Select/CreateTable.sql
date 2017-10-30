CREATE TABLE tabela_nova AS
   (SELECT * FROM tabela_existente);
   
CREATE TABLE tabela_nova AS
   (SELECT * FROM tabela_existente WHERE 1=2);
   
   #SQL Server
   
SELECT * INTO tabela_nova From tabela_existente WHERE 1=2;

#MySQL

CREATE TABLE tabela_nova LIKE tabela_existente;

#SQLite

SELECT sql FROM sqlite_master WHERE type='table' AND name='mytable';

#https://pt.stackoverflow.com/q/36700/101
