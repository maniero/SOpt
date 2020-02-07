SELECT * FROM alunos WHERE nome_aluno LIKE '%$pesquisar%' LIMIT 5 ORDER BY ano

SELECT * FROM alunos WHERE nome_aluno LIKE '%$pesquisar%' LIMIT 5 ORDER BY YEAR(data)

SELECT * FROM alunos WHERE nome_aluno LIKE '%$pesquisar%' LIMIT 5 ORDER BY data

--https://pt.stackoverflow.com/q/434447/101
