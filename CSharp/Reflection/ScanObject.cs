using static System.Console;
					
public class Program {
	public static void Main() {
        var objects = new [] {
            new {Id = 2, Nome = "Wallace"},
            new {Id = 4, Nome = "Cigano"}
        };
		WriteLine(objects.GetType());
		foreach (var user in objects) {
			WriteLine($"Meu id é {user.Id}");
			WriteLine($"Meu nome é {user.Nome}");
		}
	}
}

//https://pt.stackoverflow.com/q/134992/101
