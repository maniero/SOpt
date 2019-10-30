using static System.Console;
using System.Text;
					
public class Program {
	public static void Main() {
		WriteLine(ASCII_binary("teste"));
		WriteLine(ASCII_binaryIneficiente("teste"));
	}
	public static string ASCII_binary(string texto) {
		var converted = "";
		byte[] byteArray = Encoding.ASCII.GetBytes(texto);
		for (var i = 0; i < byteArray.Length; i++) {
			Write((char)byteArray[i]);
			for (var j = 0; j < 8; j++) {
				Write($" ({byteArray[i]} - {(byteArray[i] & 0x80)} - {((byteArray[i] & 0x80) > 0 ? "1" : "0")})");
				converted += (byteArray[i] & 0x80) > 0 ? "1" : "0";
				byteArray[i] <<= 1;
			}
			WriteLine();
		}
		return converted;
	}
	public static string ASCII_binaryIneficiente(string texto) {
		var converted = "";
		byte[] byteArray = Encoding.ASCII.GetBytes(texto);
		for (var i = 0; i < byteArray.Length; i++) {
			Write((char)byteArray[i]);
			for (var j = 0; j < 8; j++) {
				Write($" ({byteArray[i]} - {(byteArray[i])} - {((byteArray[i]) > 127 ? "1" : "0")})");
				converted += (byteArray[i]) > 127 ? "1" : "0";
				byteArray[i] *= 2;
			}
			WriteLine();
		}
		return converted;
	} 
}

//https://pt.stackoverflow.com/q/101050/101
