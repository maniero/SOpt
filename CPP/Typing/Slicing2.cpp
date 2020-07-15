struct A {
    A(int a) : a_var(a) {}
    int a_var;
};

struct B : public A {
    B(int a, int b) : A(a), b_var(b) {}
    int b_var;
};

B &getB() { //importante o retorno por referência
    static B b(1, 2);
    return b;
}

int main() {
    A a(3);
    a = getB();
    // a.a_var == 1, b.b_var não copiado para a
    B b2(3, 4);
    A &a2 = b2;
    a2 = getB();
    cout << b2.a_var << b2.b_var; //dá 1 e 4, misturou os objetos
}

//https://pt.stackoverflow.com/q/286437/101
