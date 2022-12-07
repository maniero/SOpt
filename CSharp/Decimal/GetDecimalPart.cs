using static System.Console;
using static System.Decimal;

WriteLine(GetDecimalPart(45.545M));
WriteLine(GetDecimalPart(45.54M));
WriteLine(GetDecimalPart(0.545M));
WriteLine(GetDecimalPart(-45.545M));
WriteLine(GetDecimalPart(45.5450M));
WriteLine(GetDecimalPart(999988776655.443322116M));

static int GetDecimalPart(decimal value) => (int)((Abs(value) - Floor(Abs(value))) * (decimal)System.Math.Pow(10, value.Scale));

//https://pt.stackoverflow.com/q/63881/101
