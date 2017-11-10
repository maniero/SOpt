class Fibonacci {
    public static void main(String[] args) {
        int termo1 = 0;
        int termo2 = 1; //se são dois termos, precisa de duas várias para controlar
        do {
            System.out.print(termo1 + " "); //Está mandando imprimir um dos termos
            int temp = termo1 + termo2; //somando os dois últimos termos conforme o enunciado
            termo1 = termo2;  //fazendo o primeiro termo ter o valor do segundo
            termo2 = temp; //fazendo o segundo termo ter o valor somado dos últimos termos
        } while (termo1 <= 2584); //precisa de um laço para ficar repetindo até a condição
    }
}

//https://pt.stackoverflow.com/q/254061/101
