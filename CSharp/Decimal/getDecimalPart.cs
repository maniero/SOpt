using static System.Console;
using static System.Decimal;

WriteLine(GetDecimalPart(45.545M));
WriteLine(GetDecimalPart(45.54M));
WriteLine(GetDecimalPart(0.545M));
WriteLine(GetDecimalPart(-45.545M));

static int GetDecimalPart(decimal value) {
	value = Abs(value) - Floor(Abs(value));
	do {
		value *= 10;
	} while (value != Floor(value));
	return (int)value;
}

//https://pt.stackoverflow.com/q/63881/101
