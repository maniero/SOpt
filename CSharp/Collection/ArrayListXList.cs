using System.Collections;
using System.Collections.Generic;

public class Program {
	public static void Main() {
		var array = new ArrayList() { 1, "texto" };
		var total = 0;
		foreach (var item in array) {
		    //total += item; //se tirar o comentário dá erro quando tenbtar somar a string
		}
		var list = new List<int>() { 1, /*"texto"); //<-- Error at compile process //ddaria erro aqui*/ };
		total = 0;
		foreach (var item in list) {
		     total += item;
		}
	}
}

//https://pt.stackoverflow.com/q/227678/101
