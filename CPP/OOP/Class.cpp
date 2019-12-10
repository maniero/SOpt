#include <iostream> //carrega um arquivo de definições (semelhante mas diferente do import)
using namespace std; //permite acessar os membros deste "pacote" diretamente

class Rectangle {
    int width, height; //são privados por default
  public: //tudo abaixo é público
    Rectangle(int, int); //note só a assinatura do construtor (poderia ser inline também)
    int area() { return width * height; }//implementação inline; pode escolher o + indicado
}; //declaração tem ; em alguns casos ela fica melhor em um header .hpp

Rectangle::Rectangle(int a, int b) { //implementação do construtor separado da declaração
    width = a;
    height = b;
}

int main () { //essa parte é só para testar
  Rectangle rect (3,4); //instanciação, tem outras formas de fazer o mesmo
  Rectangle rectb (5,6);
  cout << "rect area: " << rect.area() << endl;
  cout << "rectb area: " << rectb.area() << endl;
}

//https://pt.stackoverflow.com/q/117906/101
