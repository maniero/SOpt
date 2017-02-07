public string Nome { get; set; }

//

public byte Dia { get; private set; }
public byte Mes { get; private set; }
public byte Ano { get; private set; }
public bool IsBissexto { get; private set; }

//

public bool IsBissexto { 
    get {
        return (Ano % 4 == 0);
    }                   
}

//

public Decimal Nota { get; set; } = 0.00M;

//

private byte mes;
public byte Mes { 
    get {
        return mes;
    }
    set {
        if (value > 0 && value <= 12) {
            mes = value;
        }
    }
}

//Então usar:

objeto.Mes = 3;

//internamente será algo parecido com

objeto.__setMes(3);

//

class BoxedInt {
    public int Value { set; get; };
}

//que é o mesmo que:

class BoxedInt {
    int value;
    public int Value {
        set { this.value = value; }
        get { return this.value; }
    }
}

//

class BoxedInt {
    int value;
    public BoxedInt(int v) { this.value = v; }
    public int Unbox() { return this.value; }
}

//http://pt.stackoverflow.com/q/15467/101
