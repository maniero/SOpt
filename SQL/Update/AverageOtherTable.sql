UPDATE t1 SET t1.media = (t2.notaum + t2.notadois) / 2
    FROM t1 INNER JOIN t2 ON t1.nome = t2.nome;
    
--https://pt.stackoverflow.com/q/171260/101
