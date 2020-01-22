class Teste {
    int x = 5; //escopo da classe, tempo de vida de acordo com a instância
    StringBuilder txt; //o mesmo
    int Metodo(int y) { //parâmetro existe dentro da função escopo/lifetime 
        var x = 2; //note que há ambiguidade com a variável da classe
        var t = new StringBuilder(10); //variável e objeto locais vivem até a função
        for (var z = 0; z < 10; z++) { //só existe dentro deste bloco
            WriteLine(this.x * x + y * z); //desambigua e usa todas variáveis
        } //z morre aqui
        //uma tentativa de acessar z aqui produziria erro
        for (var z = 0; z < 10; z++) { //este z é diferente do outro
            t.Append(z.ToString()); //declarada fora, continuará existindo no fim do bloco
        } //z morre aqui
        txt = t; //a variável vai morrer o seu objeto sobreviverá em txt
        return x; //o valor será copiado para algum lugar, será um novo objeto igual
    } //aqui morrem x (local), y, t (não seu objeto, qua ainda tem referência)
}
static class Program {
    static int x = 10; //escopo desta classe tempo de vida da aplicação
    static void Main() { //só existe dentro desta classe
        StringBuilder t; //vive por toda função
        { //inicia um novo escopo
            var y = new Teste(); //variável e objeto têm escopo e tempo de vida deste bloco
            x = y.Metodo(3); //este x nada tem a ver com o x da outra classe, nem poderia
            t = y.txt; //o texto ainda viverá
        } //y morre aqui, seu objeto precisa viver mais porque tem uma referência para ele
        WriteLine(t); //o texto 0123456789 será impresso, ainda vive
        //não é possível acessar o conteúdo de y mais, mesmo o objeto estando vivo
        //o escopo acabou,só a referência previamente existente ainda pode acessar o objeto
    } //aqui morre t e finalmente o objeto criado por new Teste()
} //note que x não segura uma referência para o objeto, seu resultado é uma cópia
//código para demonstração simples, não faça isto em casa

//https://pt.stackoverflow.com/q/135572/101
