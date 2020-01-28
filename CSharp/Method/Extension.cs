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

//https://pt.stackoverflow.com/q/136913/101
