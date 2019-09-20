class C { //exemplo da Wikipedia
    int i;
    public:
        int Get() const {
            return i;
        }
        void Set(int j) {
            i = j;
        }
    };

    void Foo(C& nonConstC, const C& constC) {
        int y = nonConstC.Get(); // Ok
        int x = constC.Get();    // Ok: Get() é const

        nonConstC.Set(10); // Ok: nonConstC é modificável
        constC.Set(10);    // Erro! Set() permite modificar o objeto e constC é um objeto constante
    }
}

//https://pt.stackoverflow.com/q/79909/101
