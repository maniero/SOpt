using System.Collections.Generic;
using System.Linq;

public class Program {
    public static void Main() {
        var lista1 = "1,2,3,4,5,6".Split(',').ToList();
        var array = "1,2,3,4,5,6".Split(',');
        var lista2 = new List<string>(array);
    }
}

//https://pt.stackoverflow.com/q/358204/101
