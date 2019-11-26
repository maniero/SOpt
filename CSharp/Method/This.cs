using static System.Console;
					
public class Program {
	public static void Main() => new Teste().Exemplo(2);
}

class Teste {
    private int x = 0;
	private int y = 1;
    public void Exemplo(int x) {
        WriteLine(x); //imprime o parâmetro
        WriteLine(y); //imprime a variável de instância
        WriteLine(this.x); //imprime a variável de instância
    }
}

//https://pt.stackoverflow.com/a/108959/101
