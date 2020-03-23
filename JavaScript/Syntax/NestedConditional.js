var nome = prompt("Digite seu nome");
(nome === null)
    ? alert("Você clicou em cancelar")
    : (nome === "")
        ? alert("Seu nome não foi informado")
        : alert(nome);

//https://pt.stackoverflow.com/q/441060/101
