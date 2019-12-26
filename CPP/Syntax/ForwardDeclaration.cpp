#ifndef PESSOA_H
#define PESSOA_H
class Familia;
class Pessoa {
    Familia *f;
};
#endif

#ifndef FAMILIA_H
#define FAMILIA_H
class Pessoa;
class Familia {
    Pessoa *p;
};
#endif

//https://pt.stackoverflow.com/q/124398/101
