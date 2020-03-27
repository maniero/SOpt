using static System.Console;
using System.Globalization;

namespace ConsoleApplication4 {
    public class Program {
       public static void Main(string[] args) => WriteLine(double.Parse("2.0", new CultureInfo("en-US")));
    }
}

/https://pt.stackoverflow.com/q/170977/101
