using System;
					
namespace TesteData {
    public class Program {
        public static void Main(string[] args) {
            var dataAtual = DateTime.Now.Date;
            var qtdDias = 5;
		    var novaData = dataAtual.AddDays(-qtdDias);
		    Console.WriteLine(novaData);
        }
    }
}

//https://pt.stackoverflow.com/q/237114/101
