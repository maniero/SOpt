UPDATE titulo SET autorizado = 'S' FROM (
    SELECT id_titulo FROM titulo ORDER BY id_titulo DESC LIMIT 100 FOR UPDATE) subquery
    WHERE id.titulo = subquery.id_titulo;
    
--https://pt.stackoverflow.com/q/131859/101
