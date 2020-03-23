function pegaNome() {
    var nome = prompt("Digite seu nome");
    if (nome === null) {
        alert("Você clicou em cancelar");
        return;
    }
    if (nome === "") {
        alert("Seu nome não foi informado");
        return;
    }
    alert(nome);
}
pegaNome();

//https://pt.stackoverflow.com/q/441060/101
