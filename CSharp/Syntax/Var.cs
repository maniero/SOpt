var dadosProduto = from p in produtos select new { p.Nome, p.Preco };

Control botao = new Button();

dynamic variavel;

var x = 1;
var texto = "exemplo";
var botao = new Button();
var lista = new List<cliente>{ cli1, cli2 };
var dic = new Dictionary<string, Tuple<Produto, Fornecedor>>();

Dictionary<string, Tuple<Produto, Fornecedor>> dic = new Dictionary<string, Tuple<Produto, Fornecedor>>();

var valor = CalculaParcelas(total);

List<Decimal> valor = CalculaParcelas(total);

var parcelas = ObterListaParcelas(total);

var parcelas = PegaParcelasListDecimal(total); //muito feio e possivelmente problemático

var listaClientes = PegaListaClientes();

ImprimeListaQualquer(PegaListaClientes());

//https://pt.stackoverflow.com/q/47383/101
