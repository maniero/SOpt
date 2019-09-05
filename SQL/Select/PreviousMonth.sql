SELECT SUM(ProdValor) FROM vendas
    WHERE MONTH(data) = MONTH(DATE_ADD(CURDATE(),INTERVAL -1 MONTH)) AND Status = 'Aprovado'
    
--https://pt.stackoverflow.com/q/58700/101
