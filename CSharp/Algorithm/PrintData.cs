using static System.Console;

namespace POO1 {
    public class AppLivro {
        static int Main(string[] args) {
            var livro1 = new Livro();
            if (!PegaDados(livro1, 1)) return 1;
            var livro2 = new Livro();
            if (!PegaDados(livro2, 2)) return 1;
            var livro3 = new Livro();
            if (!PegaDados(livro3, 3)) return 1;
            livro1.NovoInteressado();
            livro2.NovoInteressado();
            livro3.NovoInteressado();
            livro1.Imprimir();
            livro2.Imprimir();
            livro3.Imprimir();
            return 0;
        }
        private static bool PegaDados(Livro livro, int ordem) {
            Write($"Digite o código do livro {ordem}: ");
            if (!int.TryParse(ReadLine(), out livro.codigo)) return false;
            Write($"Digite o nome do livro {ordem}: ");
            livro.titulo = ReadLine();
            Write($"Digite o autor do livro {ordem}: ");
            livro.autor = ReadLine();
            Write($"Digite a editora do livro {ordem}: ");
            livro.editora = ReadLine();
            Write($"Digite o valor do livro {ordem}: ");
            if (!decimal.TryParse(ReadLine(), out livro.valor)) return false;
            WriteLine();
            return true;
        }
    }
    public class Livro {
        public int codigo;
        public string autor;
        public string titulo;
        public string editora;
        public decimal valor;
        public int interessados;
        public void NovoInteressado() {
            WriteLine("Novo interessado");
            interessados++;
        }
        public void Imprimir() {
            WriteLine();
            WriteLine(codigo);
            WriteLine(titulo);
            WriteLine(autor);
            WriteLine(editora);
            WriteLine(valor);
            WriteLine(interessados);
        }
    }
}

//https://pt.stackoverflow.com/q/411827/101
