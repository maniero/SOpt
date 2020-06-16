using static System.Console;

public class Program {
	public static void Main() {
		WriteLine(PayCode.NotPaid.GetTypeCode());
		WriteLine((int)(PayCode.NotPaid));
		WriteLine((char)(PayCode.NotPaid));
		Teste('A');
		int x = 'B';
	}
	public static void Teste(int x) {}
}

public enum PayCode {
    NotPaid = 'N',
    Paid = 'P'
}

//https://pt.stackoverflow.com/q/457611/101
