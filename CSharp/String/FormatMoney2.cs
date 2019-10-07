using static System.Console;

namespace AtividadeRepeticao {
    class Program2 {
        static void Main() {
            decimal valor = 1000.50M;
            Write($"R$: {valor.ToString(("C"))}");
        }
    }
}

//https://pt.stackoverflow.com/q/414468/101
