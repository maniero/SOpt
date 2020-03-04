public static IEnumerable<T> Where(this IEnumerable<T> source, Func<T, bool> predicate) {
    foreach (T element in source) {
        if (predicate(element)) { //está chamando o código que executará a condição
            yield return element;
        }
    }

public static bool Any<T>(this IEnumerable<T> source, Func<T, bool> predicate) {
    foreach (T element in source) {
        if (predicate(element)) return true;
    }
    return false;
}

public static int Count<T>(this IEnumerable<T> source, Func<T, bool> predicate) {
    int count = 0;
    foreach (T element in source) {
        if (predicate(element)) {
            count++;
        }
    }
    return count;
}

//https://pt.stackoverflow.com/q/153264/101
