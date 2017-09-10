using static System.Console;

public class Program {
	public static void Main() => WriteLine(new Cores(80, 20, 160));
}

struct Cores {
	public byte R { get; }
	public byte G { get; }
	public byte B { get; }
	
	public Cores(byte r, byte g, byte b) {
		R = r;
		G = g;
		B = b;
	}
	public override string ToString() => $"{R}, {G}, {B}";
}

//https://pt.stackoverflow.com/q/236022/101
