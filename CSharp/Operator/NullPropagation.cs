string texto = null;
string parte = "";
parte = texto?.Substring(0, 1);
WriteLine($"{parte.Length}");

int tamanho = parte.Length;

int tamanho = parte?.Length;

int? tamanho = parte?.Length;

int tamanho = parte?.Length ?? 0;

Cliente cliente = clientes?[0]; //isto também é o operador de propagação de nulo

(objeto as IExemplo)?.Exemplo();

//necessário para ser thread-safe
EventHandler<decimal> precoOnChanged = OnPrecoChanged;
if (precoOnChanged != null) {
    preco = value;
    precoOnChanged (this, value);
}

preco = value;
OnPrecoChanged?.Invoke(this, value) //Invoke é usado p/ resolver ambiguidade c/ delegate

public int ProcuraTeste(string texto) { //não compila se texto for null
    Contract.Requires(texto != null); //isto pode ser eliminado do runtime
    return texto.IndexOf("teste");
}

//https://pt.stackoverflow.com/q/91785/101
