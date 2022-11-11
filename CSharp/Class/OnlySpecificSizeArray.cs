using static System.Console;

Teste teste = new();
//teste.array = new int[5];
teste.array[0] = 1;
teste.Array = new int[5];
WriteLine(teste.Array.Length);
teste.Array = new int[4];
WriteLine(teste.Array.Length);

public class Teste {
	public readonly int[] array = new int[4];
	private int[] array2 = new int[4];
	public int[] Array { get => array2;	set {
			if (value.Length == 4) array2 = value;
			//decide se quer gerar uma exceção no else
		}
	}
}

//https://pt.stackoverflow.com/q/570019/101
