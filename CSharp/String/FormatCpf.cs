using static System.Console;

WriteLine(FormatarCpf("12345678901"));
WriteLine(FormatarCpf("00123456789"));
string FormatarCpf(string cpf) => cpf.Substring(0, 3) + "." + cpf.Substring(3, 3) + "." + cpf.Substring(6, 3) + "-" + cpf.Substring(9, 2);

//https://pt.stackoverflow.com/q/75498/101
