function diaDaSemanaHoje() {
    return ["Domingo", "Segunda", "Terça", "Quarta", "Quinta", "Sexta", "Sábado"][new Date().getDay()];
}
console.log("Hoje é " + diaDaSemanaHoje());

//https://pt.stackoverflow.com/q/171565/101
