class Produto {
    ...
    public virtual void somaEstoque(int valor) { this.qtde += valor; }
}
class Metal : Produto {
    ....
    public override void somaEstoque(int valor) { this.qtde -= valor; }

class Arquivo {
    ...
    public virtual void Gerar() { ... }
}
class ArquivoWord : Arquivo {
    ...
    public void GerarDoc() { ... }
}
public class ArquivoPdf : Arquivo {
    public void GerarPdf() { ... }
}

public override void Metodo() { throw NotImplemeted(); }

class Retangulo {
    public virtual double Altura { get; set; }
    public virtual double Comprimento { get; set; }
    public double Area { get { return Altura * Comprimento; } }
}
class Quadrado : Retangulo {
    public override double Altura { set { base.Altura = base.Comprimento = value; } }
    public override double Comprimento { set { base.Altura = base.Comprimento = value; } }
}
class Calculos {
    public void MudaArea(Retangulo retangulo) {
        retangulo.Altura *= 2;
        retangulo.Comprimento *= 4;
        //faz alguma coisa
    }
    public void FazCalculo() {
        MudaArea(new Quadrado() { Altura = 2.0, Comprimento = 2.0 };
    }
}

//https://pt.stackoverflow.com/q/53468/101
