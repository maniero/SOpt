#include <cstdlib>

#include <iostream>

class Mamifero {
    public:
        Mamifero() {}~Mamifero() {}

    virtual void somMamifero() const {
        std::cout << "\n\tSom de mamifero.\n";
    }

    virtual void menu() const {
        Mamifero * mamPtr;
        int op;
        while (op != 5) {
            std::cout << "\n\t(1) Boi" <<
                "\n\t(2) Gato" <<
                "\n\t(3) Porco" <<
                "\n\t(4) Cachorro" <<
                "\n\t(5) Sair" <<
                "\n\tDigite: ";
            std::cin >> op;
            switch (op) {
            case 1:
                {
                    mamPtr = new Mamifero();
                    mamPtr - > somMamifero();
                    break;
                }
            case 2:
                {
                    mamPtr = new Mamifero();
                    mamPtr - > somMamifero();
                    break;
                }
            case 3:
                {
                    mamPtr = new Mamifero();
                    mamPtr - > somMamifero();
                    break;
                }
            case 4:
                {
                    mamPtr = new Mamifero();
                    mamPtr - > somMamifero();
                    break;
                }
            case 5:
                {
                    std::cout << "\n\tGood Bye\n\n";
                    exit(0);
                    break;
                }
            default:
                std::cout << "\n\tOpção Inválida ..!!!\n";
            }
        }
    }
};

class Boi: public Mamifero {
    public: void somMamifero() const {
        std::cout << "\n\tMuu ..! Muu..!!\n";
    }

    void menu() const {
        Mamifero * mamPtr;
        mamPtr = new Boi();
        mamPtr - > somMamifero();
    }
};

class Gato: public Mamifero {
    public: void somMamifero() const {
        std::cout << "\n\tMiAu ..! MiAu..!!\n";
    }

    void menu() const {
        Mamifero * mamPtr;
        mamPtr = new Gato();
        mamPtr - > somMamifero();
    }
};

class Porco: public Mamifero {
    public: void somMamifero() const {
        std::cout << "\n\tOinc ..! Oinc..!!\n";
    }

    void menu() const {
        Mamifero * mamPtr;
        mamPtr = new Porco();
        mamPtr - > somMamifero();
    }
};

class Cachorro: public Mamifero {
    public: void somMamifero() const {
        std::cout << "\n\tAu ..! Au..!!\n";
    }

    void menu() const {
        Mamifero * mamPtr;
        mamPtr = new Cachorro();
        mamPtr - > somMamifero();
    }
};

int main() {
    Mamifero * m = new Mamifero();;
    m - > menu();
}

//https://pt.stackoverflow.com/q/170799/101
