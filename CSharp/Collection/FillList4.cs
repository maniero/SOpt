using System;
using static System.Console;
using System.Linq;
using System.Collections.Generic;
using System.Diagnostics;

public class Program {
    public static void Main() {
		Executa(CriarCompras1);
		Executa(CriarCompras2);
		Executa(CriarCompras3);
		Executa(CriarCompras4);
		Executa(CriarCompras5);
		Executa(CriarCompras6);
	}
    public static void Teste() => WriteLine("Fazendo algo aqui");
	
	private static void Executa(Func<int, List<Compra>> metodo) {
        var stopwatch = new Stopwatch();
        stopwatch.Start();
        for (var i = 0; i < 1000; i++) metodo(50);
        stopwatch.Stop();
		WriteLine($"Tempo passado: {stopwatch.ElapsedTicks}");
	}
	
	private static List<Compra> CriarCompras1(int numComprasParaGerar) => new List<Compra>(Enumerable.Range(0, numComprasParaGerar).Select(i => new Compra()));
	
	private static List<Compra> CriarCompras2(int numComprasParaGerar) => new int[numComprasParaGerar].Select(i => new Compra()).ToList();

	private static List<Compra> CriarCompras3(int numComprasParaGerar) => (from i in new int[numComprasParaGerar] select new Compra()).ToList();

	private static List<Compra> CriarCompras4(int numComprasParaGerar) => new List<Compra>(Enumerable.Range(0, numComprasParaGerar).Select(i => new Compra()));

	private static List<Compra> CriarCompras5(int numComprasParaGerar) {
		var lstCompras = new List<Compra>();
		CriarCompras(lstCompras, numComprasParaGerar);
		return lstCompras;
	}
	
	private static void CriarCompras(List<Compra> lstCompras, int numComprasParaGerar) {
	   lstCompras.Add(new Compra());
	   if(lstCompras.Count < numComprasParaGerar) CriarCompras(lstCompras, numComprasParaGerar);
	}

	private static List<Compra> CriarCompras6(int numComprasParaGerar)	{
		List<Compra> lstCompras = new List<Compra>(numComprasParaGerar);
		for (int i = 0; i < numComprasParaGerar; i++) lstCompras.Add(new Compra());
		return lstCompras;
	}
}

public class Compra {
	public int Item = 0;
}

//https://pt.stackoverflow.com/a/89648/101
