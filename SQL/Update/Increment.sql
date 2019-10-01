DECLARE @contador int;
SET @contador = 1;
UPDATE tabela SET @contador = Posicao = @contador + 1 ORDER BY Nome;

--https://pt.stackoverflow.com/q/84215/101
