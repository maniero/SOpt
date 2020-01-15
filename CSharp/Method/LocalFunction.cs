static void mostraNome(string nome) {
    static string transformaMaiuscula(string str) => str.ToUpper();
    Console.WriteLine(transformaMaiuscula(nome));
}

//https://pt.stackoverflow.com/q/130191/101
