using static System.Console;
using System.Collections.Generic;
					
public class Program {
	public static void Main() => WriteLine(ToQueryString(new { nome = "Nome", valor = 10 }));

	public static string ToQueryString<T>(T model) {
		var query = new Dictionary<string, string>();
		foreach (var property in typeof(T).GetProperties())
			query.Add(property.Name, property.GetValue(model, null).ToString());
		return string.Join("&", query);
	}
}

//https://pt.stackoverflow.com/q/252611/101
