enum Direcao {Norte, Sul, Leste, Oeste}; //Norte é 0 e Oeste é 3
enum Permissao {Ler = 1, Escrever = 2, Apagar = 4, Executar = 8}
int p = Ler | Escrever; //vale 3 indicando que estas duas permissões estão ativas

//https://pt.stackoverflow.com/q/137393/101
