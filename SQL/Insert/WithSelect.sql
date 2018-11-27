INSERT INTO products (nome, valor, etc)
    SELECT nome, valor, etc FROM products AS P
    WHERE P.FK_ID_QUOTE = 101
    
--https://pt.stackoverflow.com/q/346142/101
