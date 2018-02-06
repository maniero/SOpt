using System;
using static System.Console;
using static System.Math;

public class Program {
    public static void Main() {
        WriteLine(Round(1190.205, 2, MidpointRounding.AwayFromZero));
        WriteLine(Round(1190.245M, 2, MidpointRounding.AwayFromZero));
    }
}

//https://pt.stackoverflow.com/q/274734/101
