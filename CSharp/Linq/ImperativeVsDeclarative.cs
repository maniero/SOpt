var lista = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };
var pares = new List<int>();
foreach (var num in lista) if (num % 2 == 0) pares.Add(num);

var lista = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };
var pares = from num in lista
                where num % 2 == 0
                select num;
pares = pares.ToList();

var lista = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };
var pares = lista.Where(num => num % 2 == 0).ToList();

//https://pt.stackoverflow.com/q/81854/101
