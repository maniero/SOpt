struct A {
    A(int) { }      // construtor de conversão
    A(int, int) { } // construtor de conversão (C++11)
    operator int() const { return 0; } // operador de cast implícito
};

struct B {
    explicit B(int) { }
    explicit B(int, int) { }
    explicit operator int() const { return 0; }
};

int main() {
    A a1 = 1;      // OK: copy-initialization chama A::A(int)
    A a2(2);       // OK: direct-initialization chama A::A(int)
    A a3 {4, 5};   // OK: direct-list-initialization chama A::A(int, int)
    A a4 = {4, 5}; // OK: copy-list-initialization chama A::A(int, int)
    int na1 = a1;  // OK: copy-initialization chama A::operator int()
    int na2 = static_cast<int>(a1); // OK: static_cast faz a inicialização
    A a5 = (A)1;   // OK: explicit cast faz o static_cast

//  B b1 = 1;      // error: copy-initialization  B::B(int) não permitida
    B b2(2);       // OK: direct-initialization chama B::B(int)
    B b3 {4, 5};   // OK: direct-list-initialization chama B::B(int, int)
//  B b4 = {4, 5}; // error: copy-list-initialization B::B(int,int) não permitida
//  int nb1 = b2;  // error: copy-initialization B::operator int() não permitida
    int nb2 = static_cast<int>(b2); // OK: static_cast faz a inicialização
    B b5 = (B)1;   // OK: explicit cast faz o static_cast
}

//https://pt.stackoverflow.com/q/126294/101
