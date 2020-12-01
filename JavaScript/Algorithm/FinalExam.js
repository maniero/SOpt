let input = prompt("Entre com as notas")
let data = input.split(' ')
let N1 = parseFloat(data.shift());
let N2 = parseFloat(data.shift());
let N3 = parseFloat(data.shift());
let N4 = parseFloat(data.shift());
let media = (N1 * 2 + N2 * 3 + N3 * 4 + N4 * 1) / 10;
console.log("Media: " + media.toFixed(1))
if (media >= 7.0) {
    console.log('Aluno aprovado.')
}else if (media.toFixed(1) >=5.0 && media.toFixed(1) <= 6.9){
    console.log('Aluno em exame.')
    let notaExame = prompt("Entre com a nota do exame");
    let mediaFinal = (parseFloat(notaExame) + parseFloat(media))/2
    if (mediaFinal <= 4.9){
        console.log('Aluno reprovado.')
        console.log('Media final: ' + mediaFinal.toFixed(1))
    } else {
        console.log('Aluno aprovado.')
        console.log('Media final: ' + mediaFinal.toFixed(1))
    }
    console.log("Nota do exame: " + notaExame)
} else {
    console.log('Aluno Reprovado')
}

//https://pt.stackoverflow.com/q/484561/101
