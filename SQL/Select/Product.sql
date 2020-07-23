SELECT *
FROM PRODUTO
WHERE grupo = 'bebidas' AND
    (preco < 10 OR estoque <= 100)
ORDER BY estoque DESC;

--https://pt.stackoverflow.com/q/309418/101
