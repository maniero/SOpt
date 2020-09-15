UPDATE cidades SET cep = SUBSTRING(cep FROM 1 FOR 5) || "-" || SUBSTRING(cep FROM 6 FOR 8);

--https://pt.stackoverflow.com/q/44631/101
