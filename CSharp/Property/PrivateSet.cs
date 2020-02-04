using static System.Console;

public class Program {
	public static void Main() {
		var x = new MinhaClasse();
		WriteLine(x.PropriedadeDeMinhaClasse);
		x.UmMetodoPublicoQualquer();
		WriteLine(x.PropriedadeDeMinhaClasse);
		x.UmMetodoPublico();
		WriteLine(x.PropriedadeDeMinhaClasse);
	}
}

public class MinhaClasse {
    public string PropriedadeDeMinhaClasse { get; private set; } = "Texto inicial"; //pode inicializar a propriedade se quiser
    private void UmMetodoPrivadoQualquer() => PropriedadeDeMinhaClasse = "Outro texto";
    public void UmMetodoPublicoQualquer() => PropriedadeDeMinhaClasse = "Novo texto"; //pode alterar em método públicos também
    public void UmMetodoPublico() => UmMetodoPrivadoQualquer(); //o único jeito de chamar um método privado externamente é dentro de um público
}

//https://pt.stackoverflow.com/q/138116/101
