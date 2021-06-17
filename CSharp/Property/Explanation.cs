x + objeto.Valor
objeto.Valor = 10

public int Valor { get; set; }

private int valor;
public int {
    get { return valor; }
    set { valor = value; }
}

private int valor;
public int getValor() {
    return valor;
}
public void setValor(int value) {
     valor = value;
}

public int Valor { get; private set; } = 10;

public int Valor { get; } = 10;

public int Valor { get; init; };

//https://pt.stackoverflow.com/q/156804/101
