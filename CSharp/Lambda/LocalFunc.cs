static void mostraNome(string nome) {
    string transformaMaiuscula(string str) { //não pode ser chamada fora de mostraNome
        return str.ToUpper();
    }
    Console.WriteLine(transformaMaiuscula(nome));
}

static void mostraNome(string nome) {
    string transformaMaiuscula(string str) => str.ToUpper(); //isto não é lambda
    Console.WriteLine(transformaMaiuscula(nome));
}

static Func<string, string> mostraNome(string nome) {
    Func<string, string> transformaMaiuscula = (string str) => str.ToUpper();
    Console.WriteLine(transformaMaiuscula(nome));
    return transformaMaiuscula; //poderá executar a lambda fora daqui
}

Func<string, string> funcao = mostraNome("João");
string maiusculo = funcao("José"); //está chamando a lambda

//https://pt.stackoverflow.com/q/181290/101
