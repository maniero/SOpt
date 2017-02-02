using System;
using System.Collections.Generic;

public class Program {
	public static Stack<int> MontaPilha() {
		var pilha = new Stack<int>(); //Cria a pilha que vai guardar ints
		pilha.Push(3261); //manda o primeiro elemento para a pilha
		pilha.Push(1352); //vai mais um elemento ficando do seu topo
		pilha.Push(723); //sucessivamente
		pilha.Push(1234);
		return pilha;
	}
	
	public static void Main() {
		var pilha = MontaPilha();
		foreach (int i in pilha) {
			Console.WriteLine(i); //acesa cada inteiro varrendo toda a pilha
		}
		
		Console.WriteLine(pilha.Pop()); //retira o elemento mais recente colocado na pilha. no exemplo passará ter apenas 3 elementos. Vai imprimir 1234
		
		Console.WriteLine(pilha.Peek()); //pega o elemento mais recente/topo sem retirá-lo. Vai imprimir 123
		
		pilha.Clear(); //limpa todos os elementos da pilha
		
		Console.WriteLine(pilha.Count); //vai imprimir 0
	}
}

//http://pt.stackoverflow.com/q/8972/101
