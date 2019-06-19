using static System.Console;

public class Program {
	public static void Main() {
		var pai = new Pai();
		WriteLine(pai.Metodo1(1).GetType());
		var filha = new Filha();
		WriteLine(filha.Metodo1(1).GetType());
		filha.PropriedadeB = "xxx";
		WriteLine(filha.Metodo1(1).GetType());
		var temp = filha.Metodo1(1);
		WriteLine(temp.PropriedadeB);
	}
}

public class Pai : Pai<Pai> { }

public class Pai<T> where T : Pai<T> {
    protected string PropriedadeA { get; set; }
    public T Metodo1(int valor) {
        //Vários procedimentos feitos aqui
        PropriedadeA = "Resultado do tratamento";
        return (T)this;
    }
}

public class Filha : Pai<Filha> {
	public string PropriedadeB { get; set; }
}

//https://pt.stackoverflow.com/q/47970/101
