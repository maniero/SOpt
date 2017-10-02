using System;
using static System.Console;
using System.Xml.Serialization;

public class Program {
	public static void Main() {
		(var ok, var nome) = EnumFromXmlAttribute<Velocidade>("02");
		if (ok) WriteLine($"O resultado é: \"{nome}\"");
		(ok, nome) = EnumFromXmlAttribute<Velocidade>("05");
		if (ok) WriteLine($"O resultado é: \"{nome}\"");
	}
	private static (bool, T) EnumFromXmlAttribute<T>(string texto) {
		var type = typeof(T);
		if (!type.IsEnum)	throw new ArgumentException("O tipo precisa ser uma enumeração");
		foreach (var item in type.GetFields())	{
			if (Attribute.GetCustomAttribute(item, typeof(XmlEnumAttribute)) is XmlEnumAttribute attribute && texto == attribute.Name)
				return (true, (T)item.GetValue(null));
		}
		return (false, default(T));
	}
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
public enum Velocidade {
	[System.Xml.Serialization.XmlEnumAttribute("01")]
	Baixa,
	[System.Xml.Serialization.XmlEnumAttribute("02")]
	Normal,
	[System.Xml.Serialization.XmlEnumAttribute("03")]
	Rapida,
}

//https://pt.stackoverflow.com/q/242632/101
