function calcularBissexto(ano) {
    return ano % 4 == 0 && ano % 100 != 0 || ano % 400 == 0 ? 'E bissexto' : 'Nao e bissexto';
}
console.log(calcularBissexto(1980));
console.log(calcularBissexto(1981));
console.log(calcularBissexto(1900));
console.log(calcularBissexto(2000));

//https://pt.stackoverflow.com/q/394953/101
