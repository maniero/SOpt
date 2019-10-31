SELECT estoque.nome, estoque.quantidade, tipos_produtos.descricao FROM estoque
    JOIN tipos_produtos on estoque.codigo_tipo = tipos_produtos.codigo AND estoque.codigo_fabricante = fabricante.codigo;
    
--https://pt.stackoverflow.com/q/419009/101
