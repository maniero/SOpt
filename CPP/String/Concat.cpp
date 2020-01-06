#include <iostream>
#include <string>
using namespace std;

bool trocarNome(string nome) {
    nome += '1';
    cout << nome; //espero que seja só para teste
    return true; //espero que vá fazer alguma coisa diferente com isto
}
int main() {
    trocarNome("Nome");
}

//https://pt.stackoverflow.com/q/125625/101
