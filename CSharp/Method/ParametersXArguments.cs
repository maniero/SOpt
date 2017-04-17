void Func1(int i, bool flag = true) { //declarou dois parâmetros
    // execução
}

void Func2(params int[] lista) { //declarou um parâmetro
    //execução
}

void Func3(bool x, bool y) {
    int z = 0;
    Func1(1); //chamou com 1 argumento
    Func1(z, x && y); //chamou com dois argumentos vindos de variável e expressão respectivamente
    Func2(1, 2, 3); //chamou com 3 argumentos
    Func1(flag : false, i : 2); //argumentos nomeados
}

//https://pt.stackoverflow.com/q/32448/101
