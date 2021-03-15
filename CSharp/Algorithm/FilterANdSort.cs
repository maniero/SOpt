using static System.Console;
using System.Linq;

public class Program {
	public static void Main() {
            int numero = int.Parse(ReadLine());
            int[] arr = new int[numero];
            for (int i = 0; i < arr.Length; i++) arr[i] = int.Parse(ReadLine());
            foreach(var item in arr.Where(x => x % 2 == 0).OrderBy(x => x)) WriteLine(item);
            foreach(var item in arr.Where(x => x % 2 != 0).OrderByDescending(x => x)) WriteLine(item);
	}
}

//https://pt.stackoverflow.com/q/499263/101
