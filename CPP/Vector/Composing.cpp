#include <string>
#include <vector>
#include <memory>
using namespace std;

class Botao {
private:
   string nome;
public:
   Botao(string texto) {
      nome = texto;
   }
};

class Caixa {
private:
   vector<shared_ptr<Botao>> botoes;
public:
   void addBotao(shared_ptr<Botao> botao) {
      botoes.push_back(botao);
   }
   shared_ptr<Botao> getBotao(int i) {
      return botoes[i];
   }
};

int main() {
   auto caixa1 = Caixa();
   auto botao1 = make_shared<Botao>("clique");
   caixa1.addBotao(botao1);
}

//https://pt.stackoverflow.com/q/99584/101
