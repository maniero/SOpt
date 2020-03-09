using static System.Console;
using System.Xml.Serialization;
					
public class Program {
	public static void Main() {
		var x = TipoDoAmbiente.Item1;
		var tipo = x.GetType(); //pega o tipo
		WriteLine(tipo);
		var membros = tipo.GetMember(x.ToString()); //pega os membros dele
		WriteLine(membros);
		var atributos = membros[0].GetCustomAttributes(typeof(XmlEnumAttribute), false); //pega os atributos do primeiro membro
		WriteLine(atributos);
		var nome = ((XmlEnumAttribute)atributos[0]).Name; //pega o nome do atributo
		WriteLine(nome);
	}
}

public enum TipoDoAmbiente {
    [XmlEnumAttribute("1")]
    Item1,

    [XmlEnumAttribute("2")]
    Item2,
}

//https://pt.stackoverflow.com/q/154462/101
