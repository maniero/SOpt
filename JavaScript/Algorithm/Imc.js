var pulalinha = function() {
    document.write("<br>");
}
var mostra = function(frase) {
    document.write(frase);
    pulalinha();
    pulalinha();
};
var calculaIMC = function(altura, peso) {
    return peso / (altura * altura);
}
var nome = prompt("Bom dia, qual seu nome?");
document.write("Seja bem vindo, " + nome);
var idade = prompt(nome + ", quantos anos você tem?");
document.write(nome + " tem " + idade + "anos");
var peso = prompt(nome + ", qual seu peso?");
document.write(nome + " tem" + peso + "quilos.");
var altura = prompt(nome + ", qual sua altura?");
document.write(nome + " tem " + altura + "de altura.");
var imcDaPessoa = calculaIMC(altura, peso);
mostra("Seu IMC é: " + imcDaPessoa);
mostra("Você está " + (imcDaPessoa - 18.5) + " pontos acima do seu peso ideal.");

//https://pt.stackoverflow.com/q/132051/101
