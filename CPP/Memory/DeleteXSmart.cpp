class Exemplo {
    resource* recurso;
    Exemplo () : recurso(new resource) { }
    ~Exemplo () { delete recurso; }
};

class Exemplo {
    std::unique_ptr<resource> recurso;
    Exemplo() : recurso(new resource) { }
};

//https://pt.stackoverflow.com/q/83886/101
