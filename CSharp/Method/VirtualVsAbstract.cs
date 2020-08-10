public abstract class Base {
    public abstract void MetodoAbstrato(string nome); //não há implementação

    public virtual void MetodoVirtual(int x) {
        //faz algo aqui
    }
}

public class Derivada : Base {
    public override void MetodoAbstrato(string nome) {
        //faz algo aqui
    }
    public override void MetodoVirtual(int x) {
        //faz algo aqui
    }
}

//https://pt.stackoverflow.com/q/158579/101
