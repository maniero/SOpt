using static System.Console;
using static System.Math;
using static MathUtil;

public class Program {
	public static void Main() {
		WriteLine(DegreeToRadian(45));
		WriteLine(RadianToDegree(0.785398163397448));
	}
}

public static class MathUtil {
	public static double DegreeToRadian(double angle) => PI * angle / 180.0;
	public static double RadianToDegree(double angle) => angle * (180.0 / PI);
}

//http://pt.stackoverflow.com/q/184690/101
