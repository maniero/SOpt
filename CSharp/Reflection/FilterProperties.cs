using System;
using static System.Console;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

public class Program {
	public static void Main() {
        foreach (var c in GetColumns()) WriteLine(c);
	}
	private static IEnumerable<string> GetColumns() => typeof(Usuario).GetProperties()
			.Where(e => e.Name != "Id" && !(Attribute.GetCustomAttribute(e, typeof(NotMappedAttribute)) is NotMappedAttribute))
			.Select(e => e.Name);
}

public class Usuario {
	[Required]
	public string Nome { get; set; }

	[Required]
	public string Login { get; set; }

	[Required]
	public string Password { get; set; }

	[NotMapped]
	[Required]
	public string ConfirmPassword { get; set; }
}

//https://pt.stackoverflow.com/q/362565/101
