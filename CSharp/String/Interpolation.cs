using static System.Console;
 
namespace CadastroDeMusicas {
    public class Disco {
        public string nome;
        public string genero;
        public string ano;
 
		public void Main() {
            Write("Digite o nome do disco: ");
            nome = ReadLine();
            Write("Digite o genero do disco: ");
            genero = ReadLine();
            Write("Digite o ano do disco: ");
            ano = ReadLine();
			exibe();
        }
 
        public void exibe() {
			WriteLine($"Nome do disco: {nome}");
			WriteLine("Genero do disco : {genero}");
			WriteLine("Ano do disco: {ano}");
        }
    }
}

//https://pt.stackoverflow.com/q/219044/101
