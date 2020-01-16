CREATE TABLE venda ( 
    nome VARCHAR(30),  
    preco DECIMAL(10, 2),
    qtde INT,
    total DECIMAL(10, 2) AS (preco * qtde)); //tem seu valor gerado por esta fórmula
    
--https://pt.stackoverflow.com/q/131002/101
