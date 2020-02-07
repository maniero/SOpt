using static System.Console;
using static System.Math;
using System.Globalization;

namespace Uri_CSharp {
    public class URI {
        public static void Main(string[] args) {
			if (double.TryParse(ReadLine(), out var raio)) {
				double area = Pow(raio, 2) * 3.14159;
				WriteLine(area.ToString("F4", new CultureInfo("pt-BR")));
			}
		}
    }
}

//https://pt.stackoverflow.com/q/141112/101
