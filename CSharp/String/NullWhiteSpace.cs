using static System.Console;
					
public class Program {
	public static void Main() {
		string nullString = null;
		string emptyString = "";
		string spaceString = "    ";
		string tabString = "\t";
		string newlineString = "\n";
		string nonEmptyString = "texto";
		WriteLine(string.IsNullOrEmpty(nullString));
		WriteLine(string.IsNullOrEmpty(emptyString));
		WriteLine(string.IsNullOrEmpty(spaceString));
		WriteLine(string.IsNullOrEmpty(tabString));
		WriteLine(string.IsNullOrEmpty(newlineString));
		WriteLine(string.IsNullOrEmpty(nonEmptyString));
		WriteLine();
		WriteLine(string.IsNullOrWhiteSpace(nullString));
		WriteLine(string.IsNullOrWhiteSpace(emptyString));
		WriteLine(string.IsNullOrWhiteSpace(spaceString));
		WriteLine(string.IsNullOrWhiteSpace(tabString));
		WriteLine(string.IsNullOrWhiteSpace(newlineString));
		WriteLine(string.IsNullOrWhiteSpace(nonEmptyString));
	}
}

//https://pt.stackoverflow.com/q/172694/101
