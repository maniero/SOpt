#include <iostream>
using namespace std;

class No{
    public:
    int dado;
    No *next;
    No(int item, No *ptr= NULL){
        dado=item;
        next=ptr;
    }
};

class Lista{
    public:
        Lista(){
        first = last = NULL;
    };
    bool listaVazia();
    void inserirInicio(int item);
    void inserirFim(int item);
    void inserirPosicao(int item, int posicao);
    void buscaItem(int item);
    void removeInicio();
    void removeFim();
    void removeItem(int item);
    void imprimirLista();
    int tamanhoLista = 0;
    bool posicaoValida(int posicao);
    private:
    No *first, *last;
};


bool Lista::listaVazia(){
    return first == NULL;
}

void Lista::inserirInicio(int item){
    first = new No(item,first);
    tamanhoLista++;
    if(last == NULL)
        last = first;
}

void Lista::inserirFim(int item){
    tamanhoLista++;
    if(last != NULL){
        last->next = new No(item);
        last = last->next;
    }else{
        first = last = new No(item);
    }
}

void Lista::inserirPosicao(int item,int posicao){
    if(posicaoValida(posicao)){
        if(posicao == 1){
        inserirInicio(item);
    }else{

        //   LOGICA PARA IMPLEMENTAR EM OUTRAS POSICOES
    }
    }else{
       cout << endl << "       POSICAO INVALIDA" << endl;
    }

}

void Lista::buscaItem(int item){
    bool found = false;
    if(listaVazia()){
       cout << endl << "       LISTA VAZIA" << endl;
    }else{
        No *aux;
        aux = first;
        while(aux != NULL){
                if(aux->dado == item){
                    cout << endl << " O VALOR: " << item  << "      FOI ENCONTRADO NA POSICAO: " <<  tamanhoLista << endl;
                    found = true;
                }
            aux = aux->next;
        }
        if(!found){
            cout << endl << "       VALOR NAO ENCONTRADO." << endl;
        }
    }
}

void Lista::removeInicio(){

    if(listaVazia()){
        cout << endl << "       LISTA VAZIA" << endl;
    }else{
        tamanhoLista--;
        if(first == last){
            delete first;
            first = last = NULL;
        }else{
            first = first->next;
        }
    }
}
void Lista::removeFim(){
    if(listaVazia()){
        cout << endl << "       LISTA VAZIA" << endl;
    }else{
        if(tamanhoLista == 1){
            removeInicio();
            return;
        }else{
            No *aux,*ant;
            aux = first;

            while(aux->next!= NULL){
                ant = aux;
                aux=aux->next;
            }
            ant->next = NULL;
            delete aux;
            tamanhoLista--;
        }
    }
}
void Lista::removeItem(int item){
    if(listaVazia()){
       cout << endl << "       LISTA VAZIA" << endl;
    } else if(tamanhoLista == 1 || first->dado == item) {
        removeInicio();
        return;
    } else {
    	No *ant = first;
        No *atu = ant->next;
        while(atu != NULL){
            if(atu->dado == item) {
                break; 
            } else {
                ant = atu; 
                atu = atu->next;
            }
        }
        if(atu != NULL) {
        	if (last == atu) {
        		last = ant;
        	}
            ant->next = atu->next;
            delete atu;
            tamanhoLista--;
        }
    }
}

void Lista::imprimirLista(){
    if(listaVazia()){
        cout << endl << "       LISTA VAZIA" << endl;
    }else{
        No *aux;
        int i = 0;
        aux = first;
        while(aux != NULL){
            cout << endl << "     VALOR: " << aux->dado << " INDICE: " << i++ <<  endl;
            aux = aux->next;
        }
    }

}
bool Lista::posicaoValida(int posicao){
    return ( (posicao > 0) && (posicao <= tamanhoLista));
}

int main() {
	Lista obj;
	obj.inserirFim(1);
	obj.inserirFim(2);
	obj.inserirFim(3);
	obj.imprimirLista();
	obj.removeItem(2);
	obj.imprimirLista();
}

//https://pt.stackoverflow.com/q/54546/101
