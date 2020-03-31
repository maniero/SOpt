function diaDaSemanaHoje() {
    var array = ["Domingo", "Segunda", "Terça", "Quarta", "Quinta", "Sexta", "Sábado"];
    var hoje = new Date();
    var diaDaSemanaHoje = hoje.getDay();
    var textoDiaDaSemanaHoje = array[diaDaSemanaHoje];
    return textoDiaDaSemanaHoje;
}
console.log("Hoje é " + diaDaSemanaHoje());

//https://pt.stackoverflow.com/q/171635/101
