public class MyList<T> : List<T> {
    public T this[int index] {
        get => base[index - 10];
        set => base[index - 10] = value;
    }
}

//https://pt.stackoverflow.com/q/108153/101
