const condicao = n => n % 2 === 0;
function PegaUltimoCondicionlamente(valorInserido, funcao) {
  for (var i = valorInserido.length - 1; i >= 0; i--) if (funcao(valorInserido[i])) return valorInserido[i];
}
console.log(PegaUltimoCondicionalmente([3, 5, 2, 4], condicao));

//https://pt.stackoverflow.com/q/271936/101
