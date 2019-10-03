using static System.Console;
using System.Collections.Generic;

public static class Sorteio {
    public static void Main() {
        int[] array = { 1, 2, 3, 4 };
        array.Shuffle();
        foreach (var valor in array) WriteLine(valor);
        WriteLine("Soma: {0}", array[0] + array[2]); // soma 1o. e 3o. elemento
        //vamos de novo
        array.Shuffle(); //com poucos númros tem chance de repetir
        WriteLine($"Soma novo sorteio: {array[0] + array[2]}"); // soma 1o. e 3o. elemento
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

        public static void Shuffle<T>(this IList<T> list, int upperItem) => list.Shuffle(0, upperItem);

        public static void Shuffle<T>(this IList<T> list) => list.Shuffle(0, list.Count);
    }
}
