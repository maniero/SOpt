using System;
using System.Diagnostics.Contracts;

public class Program {
	public static void Main() {
		short numero = 2017;
		var m = new ShortYear(numero);
		Console.WriteLine(m);
	}
}
//provavelmente teria implemnetações de operadores, outros métodos e das interfaces
//IFormattable, IConvertible, IComparable<ShortYear>, IEquatable<ShortYear> e outras
public struct ShortYear {
	public byte Year;
	public const short Century = 1900;
	public ShortYear(short value) {
		Contract.Ensures(value >= 1900 && value < 2156);
		Year = (byte)(value - Century);
	}
	public ShortYear(int value) {
		Contract.Ensures(value >= 1900 && value < 2156);
		Year = (byte)(value - Century);
	}
    public static implicit operator short(ShortYear value) => (short)(value.Year + Century);
    public static implicit operator int(ShortYear value) => value.Year + Century;
	public override int GetHashCode() => Year.GetHashCode();
	public override String ToString() => (Year + Century).ToString();
}

//https://pt.stackoverflow.com/q/221079/101
