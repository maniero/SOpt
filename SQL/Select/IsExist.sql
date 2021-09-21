SELECT 0 FROM tabela WHERE usuario = 'exemplo';

SELECT COUNT(0) FROM tabela WHERE usuario = 'exemplo';

SELECT COUNT(*) FROM tabela WHERE usuario = 'exemplo';

SELECT (SELECT COUNT(*) FROM tabela WHERE usuario = 'exemplo') > 0;

--https://pt.stackoverflow.com/q/73771/101
