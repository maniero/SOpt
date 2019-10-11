using static System.Console;

class Complex {
	private int real;
	private int imaginary;
	public Complex(int i, int j) {
		real = i;
		imaginary = j;
	}
	public override bool Equals(object o) => ((Complex)o).real == this.real && ((Complex)o).imaginary == this.imaginary;
	public override string ToString() => string.Format("{0} + {1}i", real, imaginary);
	public override int GetHashCode() => this.ToString().GetHashCode();
	public static bool operator == (Complex x, Complex y) => x.Equals(y);
	public static bool operator != (Complex x, Complex y) => !x.Equals(y);
	public static Complex operator +(Complex x, Complex y) => new Complex(x.real + y.real, x.imaginary + y.imaginary);
}
public class Program {
	public static void Main() {
		var x = new Complex(10,20);
		WriteLine(x);
		var y = new Complex(10,20);
		WriteLine(y);
		var z = y;
		WriteLine(z);
		if (x == y) WriteLine("z igual y");
		else WriteLine("x diferente y");
		if (y != z) WriteLine("y diferente z"); 
		else WriteLine("y igual z");
	}
}

//https://pt.stackoverflow.com/q/89577/101
