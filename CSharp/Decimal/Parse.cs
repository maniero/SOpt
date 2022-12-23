using static System.Globalization.CultureInfo;

if (!decimal.TryParse("10.80", InvariantCulture, out var valor)) return;
System.Console.Write(valor);

//https://pt.stackoverflow.com/q/59329/101
