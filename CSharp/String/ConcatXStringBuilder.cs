using System;
using static System.Console;
using System.Diagnostics;
using System.Text;

public class Program {
    const int Limit = 100000;
	static int[] dataInt = new int[Limit];
	static string[] dataString = new string[Limit];

    public static void Main() {
		for (int i = 0; i < Limit; i++) {
            dataInt[i] = i;
			dataString[i] = i.ToString();
        }
        Time(ConcatenationInt);
        Time(JunctionInt);
        Time(BuilderInt);
        Time(AdditionInt);
        Time(ConcatenationString);
        Time(JunctionString);
        Time(BuilderString);
        Time(AdditionString);
    }

    static void Time(Func<int> action) {
        var sw = Stopwatch.StartNew();
        int result = action();
        sw.Stop();
		WriteLine($"{result} - {sw.ElapsedTicks:000,000,000} - {action.Method.Name}");
        GC.Collect();
        GC.WaitForPendingFinalizers();
    }

    static int AdditionInt() {
		var tmp = "";
		for (int i = 0; i < Limit; i++) tmp += dataInt[i];
		return tmp.Length;            
    }

    static int AdditionString() {
		var tmp = "";
		for (int i = 0; i < Limit; i++) tmp += dataString[i];
		return tmp.Length;
    }

    static int ConcatenationInt() => string.Concat(dataInt).Length;

    static int ConcatenationString() => string.Concat(dataString).Length;

    static int JunctionInt() => string.Join("", dataInt).Length;

    static int JunctionString() => string.Join("", dataString).Length;

    static int BuilderInt() {
		var tmp = new StringBuilder();
		for (int i = 0; i < Limit; i++) tmp.Append(dataInt[i]);
		return tmp.Length;            
    }

    static int BuilderString() {
		var tmp = new StringBuilder();
		for (int i = 0; i < Limit; i++) tmp.Append(dataString[i]);
		return tmp.Length;            
    }
}

//http://pt.stackoverflow.com/q/191264/101
