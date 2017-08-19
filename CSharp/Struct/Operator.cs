using static System.Console;

public class Program {
	public static void Main() {
		var vetor = new Vetor(3, 4);
		var vetor2 = vetor * 2f;
		WriteLine($"X = {vetor2.X}, Y = {vetor2.Y}");
	}
}

public struct Vetor {
    public float X, Y;
    public Vetor(float X, float Y) {
        this.X = X;
        this.Y = Y;
    }
	public static Vetor operator *(Vetor left, float right) {
		return new Vetor(left.X * right, left.Y * right);
	}
}

//https://pt.stackoverflow.com/q/230538/101
