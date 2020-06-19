delegate(string i) { WriteLine(i); };

(i) => WriteLine(i);

public Action<string> Metodo() {
    Action<string> func = (i) => WriteLine(i);
    func("teste"); //imprime teste
    return func;
}

//https://pt.stackoverflow.com/q/243069/101
