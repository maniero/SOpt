function main() {
    var V = prompt("Entre com o valor da tensão");
    var R = prompt("Entre com o  valor da resistência");
    var corrente = calcula(V, R);
    document.write("O valor da corrente é ", corrente, "A");
}

function calcula(V, R) {
    return V / R;
}
main()

//https://pt.stackoverflow.com/q/284804/101
