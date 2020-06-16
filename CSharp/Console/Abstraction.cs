using static System.Console;

private static DateTime data = DateTime.Now;

WriteLine($"[{data.ToString("HH:mm:ss:fff")}]");
public static void WL(string format, params args) => WriteLine(format, string[] args);

public void CW(string mensagem) => WriteLine($"[{data.ToString("HH:mm:ss:fff")}]-{mensagem}");

//https://pt.stackoverflow.com/q/239676/101
