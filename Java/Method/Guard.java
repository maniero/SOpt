draw() {
    if (!isVisible()) return; //se não estiver visível não tem porque desenhar
    ...
}

bool saque(int valor) {
    if (saldo - valor + limite < 0) return false;
    ...
}

T getElement(int index) {
    if (index >= this.length) throw new OutOfBounds();
    ...
}

T join(T a, T b) {
    if (a == null) return b; //não precisa fazer a operação se o outro não existe
    if (b == null) return a;
    ...
}

//https://pt.stackoverflow.com/q/455667/101
