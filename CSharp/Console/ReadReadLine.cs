using static System.Console;
					
public class Program {
 public static void Main() {
        WriteLine("ESCOLHA UMA OPÇÃO");
        WriteLine("-----------------");
        WriteLine("1-Encriptar");
        WriteLine("2-Decriptar");
        WriteLine("-----------------");
        int escolha;
	    if (!int.TryParse(ReadLine(), out escolha)) {
			WriteLine("Opção inválida");
			return; //dá pra fazer melhor que isso, mas agora vai simples mesmo
		}
        algoritmo();
    }
    private static void algoritmo() {
        WriteLine("Digite a mensagem: ");
        var input = ReadLine();
        WriteLine("Digite a chave: ");
        var chave = ReadLine();
        //input = input.ToUpper(); //não faça isto se não precisa mesmo, em geral não precisa
        //chave = chave.ToUpper(); //tem tecnicas melhores para facilitar para o usuário não se preocupar com caixa
	}
}

//http://pt.stackoverflow.com/q/185147/101
