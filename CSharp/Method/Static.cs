using static System.Console;
					
namespace metodo_e_funcao {
    public class Program {
        public static int SomarNumeros(int a, int b) {
            int resultado = a + b;
            return resultado > 10 ? resultado : 0;
        }
        public static void dizOla() => WriteLine("Ola");
        public static void Main(string[] args) {
            WriteLine(SomarNumeros(10,11));
            dizOla();
        }
    }
}

//https://pt.stackoverflow.com/q/148868/101
