CREATE TABLE Lancamento	(id int, data date, tipo char(1), valor int);
	
INSERT INTO Lancamento (id, data, tipo, valor) VALUES
	(1, '2015/01/01', 'C', 100),
    (2, '2015/01/02', 'D', 30),
    (3, '2015/01/02', 'C', 70),
    (4, '2015/02/01', 'D', 50),
    (5, '2015/02/01', 'C', 80),
    (6, '2015/02/02', 'D', 20),
    (7, '2015/03/01', 'C', 60),
    (8, '2015/03/01', 'D', 20);
    
SELECT DATE_FORMAT(data,'%d/%m/%Y') AS data,
    SUM(IF(tipo = 'D', valor, 0)) AS debito,
    SUM(IF(tipo = 'C', valor, 0)) AS credito,
    (SELECT SUM(IF(tipo = 'C', valor, -valor)) FROM Lancamento AS L2
         WHERE DATE_FORMAT(Lancamento.data,'%Y%m') >= DATE_FORMAT(L2.data,'%Y%m')
    ) AS saldo
FROM Lancamento
GROUP BY MONTH(data), YEAR(data)

--https://pt.stackoverflow.com/q/85541/101
