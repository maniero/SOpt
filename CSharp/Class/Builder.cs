abstract class ClassePaiBuilder<T> where T : ClassePaiBuilder<T> {
    public T SetAtributo(string atributo) {
        // codigo
        return (T)(object)this;
    }

    public object Build() => new object();
}

class ClasseFilhaBuilder : ClassePaiBuilder<ClasseFilhaBuilder> {
    public ClasseFilhaBuilder SetOutroAtributo(string outroAtributo) {
        // codigo
        return this;
    }
}

public class Program {
    public void Main() =>
        new ClasseFilhaBuilder()
            .SetAtributo("atributo da classe pai")
            .SetOutroAtributo("atributo da classe filha")
            .Build();
}

//https://pt.stackoverflow.com/q/92654/101
