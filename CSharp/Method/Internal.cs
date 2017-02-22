public class Tricycle {
    //só pode ser acessado por tipos dentro da DLL
    internal void Pedal() { }
    private int wheels = 3;

    //pode ser acessado por uma classe qualquer que derive desta, ou tipos desta DLL.
    protected internal int Wheels {
        get { return wheels; }
    }
}

//http://pt.stackoverflow.com/q/186062/101
