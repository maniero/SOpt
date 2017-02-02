public static IEnumerable<T> Where(this IEnumerable<T> source, Func<T, bool> predicate) {
    foreach (T element in source) {
        if (predicate(element)) {
            yield return element;
        }
    }
}

//---------------------------------------------------------------------------------------------------

var resultado1 = from pessoa in pessoas
               where pessoa.Nome.Contains('a')
               select pessoa;
               
var resultado2 = pessoas.Where(x => x.Nome.Contains('a'));

var resultado1 = from pessoa in pessoas
               .Where(x => x.Nome.Contains('a')
               .Select(x => x);
               
var resultado1 = from pessoa in pessoas
               .Where(pessoa => pessoa.Nome.Contains('a'))
               .Select(pessoa => pessoa);

pessoa => pessoa.Nome.Contains('a')) //lambda que recebe um parâmetro chamado pessoa (o tipo é inferido)
() => Console.WriteLine("Hello World") //lambda sem parâmetro
(int x, int y) => x * y //recebendo dois parâmetros de tipos específicos e fazendo uma operação
delegate() { Console.WriteLine("Hello World"); } //usando a sintaxe de delegate

//http://pt.stackoverflow.com/q/14212/101
