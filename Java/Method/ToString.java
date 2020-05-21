public String toString() {
     return String.format("O valor do objeto é %s", String.valueOf(value);
}

public class comp {
    private String nome;
    private Data aniversario;
    public comp (String n, Data a) {
        nome = n;
        aniversario = a;
    }
    public String toString() {
        return String.format("%s - %s", nome, aniversario);
    }
    public String getTextual() {
        return String.format("O teu nome é %s , e a fazes anos no dia %s", nome, aniversario);
    }
}

//https://pt.stackoverflow.com/q/212754/101
