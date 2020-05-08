SELECT FROM tabela WHERE coluna LIKE 'teste%' //costuma ser eficiente com índice apropriado
SELECT FROM tabela WHERE coluna LIKE '%teste%' //qualquer coisa que tenha 'teste' no meio
SELECT FROM tabela WHERE coluna LIKE '%teste' //termina com teste
SELECT FROM tabela WHERE coluna LIKE 'teste_' //termina com um e apenas um caractere qq
SELECT FROM tabela WHERE coluna LIKE '_teste_' //teste no meio de 1 caractere na ponta

CREATE VIRTUAL TABLE tabela USING fts3 (col1, col2, text );
INSERT INTO tabela VALUES ('3', 'testo', 'Este é um exemplo');
INSERT INTO tabela VALUES ('24', 'exemplo', 'Ok, está bom assim');
INSERT INTO tabela VALUES ('13', 'outro', 'Finalizando');
SELECT * FROM tabela WHERE tabela MATCH "exemplo"

--https://pt.stackoverflow.com/q/191573/101
