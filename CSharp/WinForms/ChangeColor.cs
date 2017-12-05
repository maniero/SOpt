using static System.Console;
using System.Drawing;

public class Program {
	public static void Main() {
		Color slateBlue = Color.FromName("SlateBlue");
	    WriteLine($"Slate Blue has these ARGB values: Alpha:{slateBlue.A}, red:{slateBlue.R}, green: {slateBlue.B}, blue {slateBlue.G}");
	}
}

//https://pt.stackoverflow.com/q/260495/101
