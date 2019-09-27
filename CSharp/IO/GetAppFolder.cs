using static System.Console;
using System.IO;
using System.Reflection;

public class Program {
    public static void Main() => WriteLine(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"script.sql"));
}

//https://pt.stackoverflow.com/q/84044/101
