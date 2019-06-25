using static System.Console;

public class Program {
	public static void Main() {
		WriteLine(((int)SourceSystem.Mirror));
	}
}

public enum SourceSystem {
    Unknown = 0,
    Mirror = 3,
    MirrorTrident = 17
}

//https://pt.stackoverflow.com/q/393416/101
