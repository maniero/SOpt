SELECT SUM((qtd - qtd_devolucao) * valor) AS total
   FROM produtos
   WHERE id_pedido = '47'
   
--https://pt.stackoverflow.com/q/224785/101
