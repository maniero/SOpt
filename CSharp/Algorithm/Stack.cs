using static System.Console;
using System.Collections.Generic;
					
public class Program {
	public static void Main() {
		WriteLine("<Pilha>");
		var minhaPilha = new Stack<string>();
		minhaPilha.Push("Primeira");
		minhaPilha.Push("Segunda");
		minhaPilha.Push("Terceira");
		minhaPilha.Push("Quarta");
		WriteLine("Para add itens, selecione X");
		WriteLine();
		WriteLine("Para remover itens, selecione Z");
		WriteLine();
		WriteLine("Caso queira remover um dado especifico digite W");
		var opc = ReadLine();
		foreach (var carta in minhaPilha) WriteLine(carta);
		if (opc == "Z") {
			WriteLine();
			minhaPilha.Pop();
			foreach (var carta in minhaPilha) WriteLine(carta);
		}
		if (opc == "X") {
			WriteLine("Digite aqui:");
			minhaPilha.Push(ReadLine());
			WriteLine();
			foreach (var carta in minhaPilha) WriteLine(carta);
		}
		if (opc == "W") {
			WriteLine("Qual elemento:");
			var selecionado = ReadLine();
			var novaPilha = new Stack<string>();
			var totalItens = minhaPilha.Count;
			for (var i = 0; i < totalItens; i++) {
				if (minhaPilha.Peek() == selecionado) {
					minhaPilha.Pop();
					break;
				} else {
					novaPilha.Push(minhaPilha.Pop());
				}
			}
			totalItens = novaPilha.Count;
			for (var i = 0; i < totalItens; i++) minhaPilha.Push(novaPilha.Pop());
			foreach (var carta in minhaPilha) WriteLine(carta);
		}
		WriteLine();
	}
}

//https://pt.stackoverflow.com/q/84091/101
