using static System.Console;

public class Program {
	public static void Main() {
		WriteLine(PayCode.NotPaid.GetTypeCode());
		WriteLine((int)(PayCode.NotPaid));
	}
}

public enum PayCode {
    NotPaid = 'N',
    Paid = 'P'
}

//https://pt.stackoverflow.com/q/457611/101
