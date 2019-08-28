#include <iostream>
using namespace std;

template <class T>
class elemento {
	public:
	    T dado;
    	elemento<T> *prox;
};

template <class T>
class pilha {
private:
    elemento<T> *top;
public:
    pilha() { top = NULL; }
    bool empilha(T);
    T topo();
    T pop();
    bool vazio();
    ~pilha();
};

template <class T>
pilha<T>::~pilha() {
    delete [] top;
}

template <class T>
bool pilha<T>::empilha(T x) {
    if (top == NULL) {
        top = new elemento<T>;
        top->dado = x;
        top->prox = NULL;
        return true;
    } else {
        elemento<T> *aux = new elemento<T>;
        aux->dado = x;
        aux->prox = top;
        top = aux;
        return true;
    }
    return false;
}

template <class T>
T pilha<T>::topo() {
    if (!vazio()) return top->dado;
    return -1; //RETORNA -1 QUANDO A PILHA ESTA VAZIA
}

template <class T>
T pilha<T>::pop() {
    if (vazio()) return -1; //RETORNA -1 QUANDO A PILHA ESTA VAZIA
    else {
        T aux = top->dado;
        top = top->prox;
        return aux;
    }
}

template <class T>
bool pilha<T>::vazio() { return (top==NULL); }

using namespace std;

int main() {
    pilha<int> p;
    if (!p.vazio()) {
        cout<<p.topo()<< endl;
    }
    p.empilha(1);
    cout<<p.pop()<< endl;
    p.empilha(2);
    cout<<p.pop()<< endl;
    p.empilha(3);
    cout<<p.pop()<< endl;
    p.empilha(4);
    cout<<p.pop()<< endl;
    p.empilha(5);
    cout<<p.pop()<< endl;
    p.empilha(6);
    p.empilha(7);
    p.empilha(8);
    cout<<p.pop()<< endl;
    p.empilha(9);
    p.empilha(10);
    p.empilha(11);
    p.empilha(12);
    p.empilha(13);
    cout<<p.pop()<< endl;
    p.empilha(14);
    cout<<p.topo()<< endl;
    cout<<p.pop()<< endl;
    cout<<p.pop()<< endl;
    cout<<p.pop()<< endl;
    cout<<p.pop()<< endl;
    cout<<p.pop()<< endl;
    cout<<p.pop()<< endl;
    cout<<p.pop()<< endl;
    cout<<p.pop()<< endl;
}

//https://pt.stackoverflow.com/q/55871/101
