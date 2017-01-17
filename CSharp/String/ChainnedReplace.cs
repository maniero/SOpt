public class Program {
	public static void Main() => System.Console.WriteLine(System.DateTimeOffset.Now.ToString("o").Replace(':', '-').Replace('/', '-') + "_teste.txt");
}

//http://pt.stackoverflow.com/q/177896/101
