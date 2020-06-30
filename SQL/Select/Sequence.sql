INSERT INTO contatos (cod, nome)
SELECT (SELECT MAX(cod) FROM contatos) + cod, nome FROM fornecedores;

--https://pt.stackoverflow.com/q/257055/101
