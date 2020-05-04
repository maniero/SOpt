using static System.Console;

public class Program {
	public static void Main() {
        WriteLine("Digite um número:");
        var aluno = ReadLine();
        var nota1 = 0.0;
  	    var nota2 = 0.0;
		var nota3 = 0.0;
		var nota4 = 0.0;
        var media = (nota1 + nota2 + nota3 + nota4) / 4;
        WriteLine ($"{aluno} tem média {media} está: {(media >= 5 ?  "Aprovado;" : "Reprovado")}.");
	}
}

//https://pt.stackoverflow.com/q/449581/101
