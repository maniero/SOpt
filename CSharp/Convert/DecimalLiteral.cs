using static System.Console;

public class Program {
	public static void Main() {
		decimal contagemSubida = 0 , contagemDescida = 0;
        int cSubida = 6, cDescida = 4, range = 10;
        contagemSubida += cSubida * range / 100M;
        contagemDescida += cDescida * range / 100M;
        contagemSubida += contagemSubida * (4 / 10M);
        contagemDescida += contagemDescida * (4 / 10M);
		WriteLine(contagemSubida);
		WriteLine(contagemDescida);
	}
}

//https://pt.stackoverflow.com/q/340525/101
