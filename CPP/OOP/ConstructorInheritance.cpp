#include <iostream>
#include <string>
#include <vector>
using namespace std;

class animal {
protected:
    string nome;
    int idade;
public:
    animal(const string &nome_, int idade_);
    virtual void emitirSom() const = 0;
};

class cachorro : public animal {
public:
    cachorro(const string &nome_, int idade_);
    virtual void emitirSom() const;
};

class vaca : public animal {
public:
    vaca(const string &nome_, int idade_);
    virtual void emitirSom() const;
};

class gato: public animal {
public:
    gato(const string &nome_, int idade_);
    virtual void emitirSom() const;
};

animal::animal(const string &nome_, int idade_) {
    nome = nome_;
    idade = -idade_;
}

cachorro::cachorro(const string &nome_, int idade_) : animal(nome_, idade_) {}

void cachorro::emitirSom() const {
    cout << "\n" << nome << "latindo: Aauauauauau";
}

gato::gato(const string &nome_, int idade_) : animal(nome_, idade_) {}

void gato::emitirSom() const {
    cout << "\n" << nome << "miando: MiauMiau";
}

vaca::vaca(const string &nome_, int idade_) : animal(nome_, idade_) {}

void vaca::emitirSom() const {
    cout << "\n" << nome << "mugindo: Muuuuuuu";
}

void fazerBarulho(const animal* const &bicho) {
    bicho->emitirSom();
}

int main() {
    cachorro toby("Toby", 8);
    vaca lili("Lili",29);
    gato satanas("Satanas",3);
    vector < animal * > zoo( 3 );
    zoo[0] = &toby;
    zoo[1] = &lili;
    zoo[2] = &satanas;
    for (size_t i = 0; i < zoo.size(); ++i) fazerBarulho(zoo[i]);
}

//https://pt.stackoverflow.com/q/240500/101
