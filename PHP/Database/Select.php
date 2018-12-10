SELECT b.idBanca AS idB, b.DataHora AS dataHora, 
       b.Sala AS sala, t.idTrabalho AS idT, 
       p.Nome AS orientador, a.Nome AS aluno, t.Nome AS trabalho 
FROM Bancas b 
INNER JOIN Trabalhos t ON t.idTrabalho = b.idTrabalho 
INNER JOIN Professores p ON t.idProfessor = p.idProfessor 
INNER JOIN Alunos a ON t.idAluno = a.idAluno 
INNER JOIN ProfessoresBancas pb ON b.idBanca = pb.idBanca 
WHERE t.idSemestre = '$idSemestre' AND 
       (p.idProfessor = '$idProfessor' OR pb.idProfessor = '$idProfessor')
ORDER BY dataHora

//https://pt.stackoverflow.com/q/43332/101
