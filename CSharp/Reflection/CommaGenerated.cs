using System;
					
public class Program {
	public static void Main() {
		Console.WriteLine(ToSeparatedCommaString<DateTimeKind>(new DateTimeKind[] {DateTimeKind.Local, DateTimeKind.Unspecified, DateTimeKind.Utc}));
	}
	public static string ToSeparatedCommaString<T>(T[] enums) where T : struct, IComparable, IFormattable, IConvertible { //Não garante que seja enum mas sempre limita alguma coisa
		var commaString = string.Empty;
		if (!typeof(T).IsEnum) {
			throw new ArgumentException("Tipo de enums é inválido");
		}
		foreach (var item in enums)	{
			Enum enumerador = item as Enum;
			commaString += enumerador.GetStringValue() + ",";
		}
		return commaString.TrimEnd(',');
	}
}

public static class EnumExt {
	public static string GetStringValue(this Enum value) => "nome"; //só para testar
}

//https://pt.stackoverflow.com/q/57318/101
