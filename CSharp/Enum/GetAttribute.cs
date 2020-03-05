using System;
using System.Xml.Serialization;
					
public class Program {
	public static void Main() {
		var x = TNFeInfNFeDetImpostoICMSICMS00CST.item00;
		Console.WriteLine(x.GetAttributeDescription());
	}
}

public static class EnumExt {
	public static string GetAttributeDescription(this Enum enumValue) {
        var attributes = enumValue.GetType().GetMember(enumValue.ToString())[0].GetCustomAttributes(typeof(XmlEnumAttribute), false);
		return (attributes.Length > 0) ? ((XmlEnumAttribute)attributes[0]).Name : String.Empty;
	}
}

public enum TNFeInfNFeDetImpostoICMSICMS00CST {
    [XmlEnumAttribute("00")]
    item00 = 00,
}

//https://pt.stackoverflow.com/q/153789/101
