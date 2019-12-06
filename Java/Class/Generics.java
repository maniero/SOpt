class Exemplo<T> {
    private T x;
    Exemplo(T x) => this.x = x;
    public T getValue() => x;
}

Exemplo<String> teste1 = new Exemplo<String>("teste");
teste1.getValue();
Exemplo<Boolean> teste2 = new Exemplo<Boolean>(true);
teste2.getValue();

//https://pt.stackoverflow.com/q/111749/101
