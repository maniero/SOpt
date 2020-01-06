using static System.Console;
using System;
using System.Text;

public static class Boleto {
	public static string Modulo11LinhaDigitavel(string valor, int digitoBase = 9, bool resto = false) {
		var linha = new StringBuilder(valor.Length);
		for (var i = 0; i < valor.Length; i++) {
			if ("0123456789".IndexOf(valor[i]) >= 0) linha.Append(valor.Substring(i, 1));
		}
		var linhaOrdenada = linha.ToString();
        linhaOrdenada = linhaOrdenada.Substring(0, 4) + 
                        linhaOrdenada.Substring(32, 15) + 
                        linhaOrdenada.Substring(4, 5) +  
                        linhaOrdenada.Substring(10, 10) + 
                        linhaOrdenada.Substring(21, 10); 
        linhaOrdenada = linhaOrdenada.Substring(0, 4) + linhaOrdenada.Substring(5, 39);
		var soma = 0;
		var peso = 2;
		for (var i = linhaOrdenada.Length - 1; i >= 0; i--) {
			soma += Convert.ToInt32(linhaOrdenada.Substring(i, 1)) * peso;
			if (peso < digitoBase) peso++;
			else peso = 2;
		}
		var retorno = "";
		if (resto) {
			retorno = (soma % 11).ToString();
		} else {
			var digito = 11 - (soma % 11);
			if (digito > 9) { 
				digito = 0;
			}
			retorno = digito.ToString();
		}
		if (retorno == "0") return "1";
		return retorno;
	}

// Uma vez funcionado, teria que retornar 5, que é o DV da linha digitável abaixo em questão        
	public static void Main(string[] args) {
		WriteLine(Modulo11LinhaDigitavel("10490.05539 03698.700006 00091.449587 5 55490000028531"));
		WriteLine(Modulo11LinhaDigitavel("34198.85912 01354.522771 90199.970006 7 55100000500000"));
		WriteLine(Modulo11LinhaDigitavel("39992.84841 90000.001702 12459.064122 1 48970000041452"));
		WriteLine(Modulo11LinhaDigitavel("03399.54083 26100.000129 04389.301021 8 57750000008990"));
		WriteLine(Modulo11LinhaDigitavel("23792.02803 60002.775660 63002.490009 3 53270000121000"));
		WriteLine(Modulo11LinhaDigitavel("34191.75009 37645.262934 80706.420009 9 57680000521600"));
		WriteLine(Modulo11LinhaDigitavel("10490.05539 03698.700006 00350.368361 4 67750000010156"));
	}
}

//https://pt.stackoverflow.com/q/125480/101
