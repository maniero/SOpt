using static System.Console;
using static System.Convert;
					
public class Program {
	public static void Main() {
		WriteLine(GenerateKey("10000"));
		WriteLine(GenerateKey("10011"));
		WriteLine(GenerateKey("10100"));
		WriteLine(GenerateKey("00000"));
		WriteLine(GenerateKey("999999999"));
	}
	public static int GenerateKey(string s) {           
		s = s.Remove(s.Length - 1);
		var i = ToInt32(s);
		var sum = 0;
		while (i != 0) {
			sum += i % 10;
			i /= 10;
		}
		var somatorio = ToInt32(s) + 1;
		var id = somatorio.ToString();
		if (sum.ToString().Length > 1) sum %= 10;
		id += sum;
		return ToInt32(id);
	}
}

//https://pt.stackoverflow.com/q/92839/101
