using static System.Console;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
					
public class Program {
	public static void Main() {
		var lstObj = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };
		Parallel.ForEach(lstObj, obj => MetodoX(obj));
		WriteLine("Fim"); //aqui poderia ser o MetodoY()
	}
	public static void MetodoX(int obj) => WriteLine($"ThreadID: {Thread.CurrentThread.ManagedThreadId, 3}, Valor: {obj}");
}

//https://pt.stackoverflow.com/q/57934/101
