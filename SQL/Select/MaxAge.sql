SELECT nome, idade FROM pessoas ORDER BY idade DESC LIMIT 1;

SELECT nome, idade FROM pessoas WHERE idade = (SELECT MAX(idade) FROM pessoas);

--https://pt.stackoverflow.com/q/345185/101
