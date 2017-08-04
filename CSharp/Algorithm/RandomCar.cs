using System;
using static System.Console;
using System.Collections.Generic;

public class MainClass {
    public static Random Random = new Random();

	public static List<string> Marcas= new List<string>() { "Toyota", "BMW", "Volkswagen", "GM", "Mercedes" };
	public static List<string> Modelos = new List<string>() { "1.0", "1.4", "1.6", "1.8", "2.0" };
	public static List<string> Cores = new List<string>() { "Branco", "Prata", "Preto", "Cinza", "Vermelho" };

	public static void Main(string[] args) {
		for (int i = 1; i <= 5; i++) {
			var carro = gerarCarro();
			WriteLine(carro.Marca);
			WriteLine(carro.Modelo);
			WriteLine(carro.Cor);
			WriteLine(carro.Ano);
			WriteLine();
    	}
	}
	public static Carro gerarCarro() {
		return new Carro() {
			Marca = Marcas[Random.Next(0, 5)],
			Modelo = Modelos[Random.Next(0, 5)],
			Cor = Cores[Random.Next(0, 5)],
			Ano = Random.Next(2000, 2018) };
  	}
	public class Carro {
		public string Marca { get; set; }
		public string Modelo { get; set; }
		public string Cor { get; set; }
		public int Ano { get; set; }
	}
}

//https://pt.stackoverflow.com/q/226458/101
