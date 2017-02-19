using static System.Console;
					
public class Program {
	public static void Main() {
        int escolha = 1;
		while (escolha != 0) {
			WriteLine("ESCOLHA UMA OPÇÃO");
			WriteLine("-----------------");
			WriteLine("1-Encriptar");
			WriteLine("2-Decriptar");
			WriteLine("0-Encerrar");
			WriteLine("-----------------");
			if (!int.TryParse(ReadLine(), out escolha) || escolha < 0 || escolha > 2) {
				WriteLine("Opção inválida");
				continue;
			}
			if (escolha != 0) {
				WriteLine("Digite a mensagem: ");
				var mensagem = ReadLine();
				WriteLine("Digite a chave: ");
				var chave = ReadLine();
				WriteLine(mensagem.ToUpper());
				WriteLine(chave.ToUpper());
				WriteLine(CifraVigenere(mensagem, chave, escolha == 1));
			}
		}
	}
	private static string CifraVigenere(string mensagem, string chave, bool flag) { //normalmente não deveria escolher um método por um bool
        if (flag) {
			var codigo = "";
            for (int i = 0, j = 0; i < mensagem.Length; i++, j++) {
				char c = char.ToUpper(mensagem[i]);
				if (c < 'A' || c > 'Z') {
					continue;
				}
				codigo += (char)((c + char.ToUpper(chave[j % chave.Length]) - 2 * 'A') % 26 + 'A');
            }
            return codigo;
		}
		return ""; //até criar o decript
    }
}

//http://pt.stackoverflow.com/q/185158/101
