function calculaIdade(anoAtual, anoNascimento) {
    return anoAtual - anoNascimento;
}

function imprimeSePodeDirigir(anoAtual, anoNascimento) {
let idade = calculaIdade(anoAtual, anoNascimento);
    if (idade >= 18) {
        console.log(` sua idade é ${idade} você já pode dirigir`);
    } else {
        console.log(`sua idade é ${idade} você ainda não pode dirigir`);
    }
}
let anoAtual = 2020;
let anoNascimento = 2005;
imprimeSePodeDirigir(anoAtual, anoNascimento);

//https://pt.stackoverflow.com/q/439808/101
