foreach (var item in clientes) item.NomeFantasia.Replace("*", "");

foreach (var item in clientes) item.NomeFantasia.TrimStart('*');

var resultado = clientes.Select(item => { item.NomeFantasia.TrimStart('*'); return item; })

//https://pt.stackoverflow.com/q/80773/101
