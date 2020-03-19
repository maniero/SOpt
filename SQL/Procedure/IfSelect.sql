IF (SELECT (f.Email IS NULL OR RTRIM(f.Email) = '') FROM Funcionario f WHERE f.FuncionarioID = 1) THEN END

--https://pt.stackoverflow.com/q/164603/101
