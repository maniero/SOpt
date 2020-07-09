ViewBag.Mensagem = "O que deseja passar aqui";
ViewBag.Valor = 1;

@ViewBag.Mensagem
@ViewBag.Valor

ViewData["mensagem"] = "O que deseja passar aqui";
ViewData["valor"] = 1;

@(string)ViewData["mensagem"] //tecnicamente esta conversão pode ser feita automaticamente
@(int)ViewData["valor"] //a conversão não é necessária se apenas deseja imprimir

//https://pt.stackoverflow.com/q/273504/101
