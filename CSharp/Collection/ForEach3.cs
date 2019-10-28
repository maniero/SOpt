using static System.Console;
using System.Collections.Generic;
					
public class Program {
    public static void Main() {
        List<string> names = new List<string>();
        names.Add("Bruce");
        names.Add("Alfred");
        names.Add("Tim");
        names.Add("Richard");
        names.ForEach(Print);
        names.ForEach((string name) => WriteLine(name));
    }

    private static void Print(string s) => WriteLine(s);
}

//https://pt.stackoverflow.com/q/98297/101
