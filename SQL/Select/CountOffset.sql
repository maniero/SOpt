SELECT COUNT(*) AS total FROM (SELECT 1 FROM noticias ORDER BY data_noticia DESC LIMIT 30 OFFSET 2) AS resultado;

==https://pt.stackoverflow.com/q/328001/101
