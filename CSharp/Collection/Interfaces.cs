public interface IEnumerable<out T> : IEnumerable {
    new IEnumerator<T> GetEnumerator();
}

public interface ICollection<T> : IEnumerable<T> {
    int Count { get; }
    bool IsReadOnly { get; }
    void Add(T item);
    void Clear();
    bool Contains(T item); 
    void CopyTo(T[] array, int arrayIndex);
    bool Remove(T item);
}

public interface IList<T> : ICollection<T> {
    T this[int index] { get; set; }
    int IndexOf(T item);
    void Insert(int index, T item);
    void RemoveAt(int index);
}

List<string> listaC = new List<string>();
IList<string> lista = new List<string>();
ICollection<string> colecao = new List<string>();
IEnumerable<string> enumeracao = new List<string>();

colecao = new LikedList();

enumeracao.Reverse(); //gera erro de compilação
colecao[0]; //erro também.
lista.RemoveAt(0); //funciona
listaC.Add("teste"); //funciona, o método está dentro da hierarquia

//https://pt.stackoverflow.com/q/76316/101
