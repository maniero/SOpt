.Select(s => new { Codigo = s.id_sub_categoria,
                   SubCategoria = s.descricao,
                   CodigoCategoria = s.CategoriaProduto.id_categoria,
                   Categoria = s.CategoriaProduto.descricao})

var x = new Tipo { Prop1 = 1, Prop2 = "teste" }; //esta estrutura está definida em Tipo

var x = new { Prop1 = 1, Prop2 = "teste" }; //esta estrutura está sendo "inventada" agora

.Select(s => return new { Codigo = s.id_sub_categoria,
               SubCategoria = s.descricao,
               CodigoCategoria = s.CategoriaProduto.id_categoria,
               Categoria = s.CategoriaProduto.descricao})

.Select(s => 1)

select 1

//https://pt.stackoverflow.com/q/134071/101
