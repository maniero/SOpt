using static System.Console;
using System.Collections.Generic;

class Program {
    static void Main() {
        string[] temp = ReadLine().Split(new char[] { ' ' });
        var maior = new List<double> {
            double.TryParse(temp[0], out var valido) ? valido : 0,
            double.TryParse(temp[1], out valido) ? valido : 0,
            double.TryParse(temp[2], out valido) ? valido : 0
        };
        maior.Sort();
        WriteLine($" {maior[2]} eh o maior"); 
    }
}

//https://pt.stackoverflow.com/q/312752/101
