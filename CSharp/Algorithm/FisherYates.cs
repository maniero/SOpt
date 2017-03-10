using static System.Console;
using System.Collections.Generic;

public static class Sorteio {
    public static void Main() {
        var lista = new List<string>() { "Alaor", "Joseval", "Salustiano", "Gomide", "Castro" };
        lista.Shuffle();
        foreach (var valor in lista) {
            WriteLine(valor);
        }
        WriteLine("//////////");
        string[] array = { "Alaor", "Joseval", "Salustiano", "Gomide", "Castro" };
        array.Shuffle(2);
        foreach (var valor in array) {
            WriteLine(valor);
        }
        WriteLine("//////////");
        int[] array2 = { 1, 2, 3, 4, 5 };
        array2.Shuffle(1,4);
        foreach (var valor in array2) {
            WriteLine(valor);
        }
    }
}

namespace System.Collections.Generic {
    public static class IListExt {
        static Random r = new Random(DateTime.Now.Millisecond);

        public static void Shuffle<T>(this IList<T> list, int lowerItem, int upperItem) {
            upperItem = upperItem > list.Count ? list.Count : upperItem;
            lowerItem = lowerItem < 0 ? 0 : lowerItem;
            for (int i = lowerItem; i < upperItem; i++) {
                int j = r.Next(i, upperItem);
                T tmp = list[j];
                list[j] = list[i];
                list[i] = tmp;
            }
        }

        public static void Shuffle<T>(this IList<T> list, int upperItem) {
            list.Shuffle(0, upperItem);
        }

        public static void Shuffle<T>(this IList<T> list) {
            list.Shuffle(0, list.Count);
        }
    }
}

//http://pt.stackoverflow.com/q/17783/101
