using static System.Console;
using System.Text;
using System.Diagnostics;
					
public class Program {
	public static void Main() {
		var sw = new Stopwatch();
		sw.Start();
		for (var i = 0; i < 1000; i++) ASCII_binary("teste");
		sw.Stop();
		WriteLine(sw.ElapsedTicks);
		sw.Restart();
		for (var i = 0; i < 1000; i++) ASCII_binaryIneficiente("teste");
		sw.Stop();
		WriteLine(sw.ElapsedTicks);
	}
	public static string ASCII_binary(string texto) {
		var converted = "";
		byte[] byteArray = Encoding.ASCII.GetBytes(texto);
		for (var i = 0; i < byteArray.Length; i++) {
			for (var j = 0; j < 8; j++) {
				converted += (byteArray[i] & 0x80) > 0 ? "1" : "0";
				byteArray[i] <<= 1;
			}
		}
		return converted;
	} 
	public static string ASCII_binaryIneficiente(string texto) {
		var converted = "";
		byte[] byteArray = Encoding.ASCII.GetBytes(texto);
		for (var i = 0; i < byteArray.Length; i++) {
			for (var j = 0; j < 8; j++) {
				converted += (byteArray[i]) > 127 ? "1" : "0";
				byteArray[i] *= 2;
			}
		}
		return converted;
	} 
}

//https://pt.stackoverflow.com/q/101050/101
