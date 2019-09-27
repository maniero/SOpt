using static System.Console;
					
public class Program {
	public static void Main() {
		var texto = "240144|000|5511946724649|2015-08-30 21:45:51|2015-08-30 21:46:02|1|";
		var items = texto.Split('|');
		foreach (var item in items) WriteLine(item);
		var data = items[4];
	}
}

//https://pt.stackoverflow.com/q/83836/101
