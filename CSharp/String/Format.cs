using static System.Console;
					
public static class Program {
    const string interpolado = "{0}"; 

    public static void Main (string [] args) {
        var firstName = "fred";
        WriteLine(interpolado, firstName);
		var texto = string.Format(interpolado, firstName);
        WriteLine(texto);
     }
}

//https://pt.stackoverflow.com/q/136458/101
