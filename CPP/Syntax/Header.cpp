#include <string>
using namespace std;

class Nome {
        string nome;
        string sobreNome;
    public:
        Nome(string nome, string sobreNome);
        void exibirNome();
        virtual ~Nome(); //espero que vá usar, senão não tem porque criar isto
};

int main() {}

//https://pt.stackoverflow.com/q/120211/101
