using static System.Console;
					
public class Program {
	public static void Main() => new Exemplo().Ex();
}
	
public class Exemplo {
	public int Ex() {
		var nomeMetodo = "Macaco" + "Animation";
		var Metodo = this.GetType().GetMethod(nomeMetodo);
		WriteLine(Metodo.Invoke(this, null));
		return 0;
	}
	
	public string MacacoAnimation() => "macaco";
}

//https://pt.stackoverflow.com/q/83577/101
