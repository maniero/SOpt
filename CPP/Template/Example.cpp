template <class Type>
class No<Type> {
public:
    Type exp;
    No<Type>* prox;
    No<Type>(){prox = NULL;}
};


template <class Type>
class pilha<Type> {
    public:
        pilha();
        void push(Type expressao);
        Type pop();
        Type getTop();
        bool isEmpty();
        bool clear();
        void print();
    private:
    No<Type>* topo; //aqui deve ser sua dúvida, tem que instanciar parametrizado
};

//https://pt.stackoverflow.com/q/57790/101
