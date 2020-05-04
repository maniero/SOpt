using static System.Console;

public class Program {
	public static void Main() {
		var filha = new Filha();
		filha.y = 1;
		var mae = (Mae)filha;
		var filha2 = (Filha)mae;
		WriteLine(filha2.y);
		mae.Virtual();
		mae.Real();
		filha2.Virtual();
		filha2.Real();
	}
}

class Mae {
	public virtual void Virtual() => WriteLine("Mãe");
	public void Real() => WriteLine("Mãe");
}
class Filha : Mae {
	public int y;
	public override void Virtual() => WriteLine("Filha");
	public new void Real() => WriteLine("Filha");
}

//https://pt.stackoverflow.com/q/449584/101
