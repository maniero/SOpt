using static System.Console;
using System.Reflection;

public class Program {
	public static void Main() {
		var xml = new Servico();
		var tipoServico = xml.GetType();
		tipoServico.InvokeMember("SalvarXmlRetornoEm", BindingFlags.SetProperty, null, xml, new object[] { "local" });
		WriteLine(xml.SalvarXmlRetornoEm);
	}
}

//pra simplificar vou fazer um tipo em código mesmo

public class Servico {
	public string SalvarXmlRetornoEm { get; set; }
}

//https://pt.stackoverflow.com/q/208767/101
