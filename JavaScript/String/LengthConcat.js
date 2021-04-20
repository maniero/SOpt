function nomeCompletoETamanho(nome, sobrenome) {
  return {
    tamanho: nome.length + sobrenome.length + 1, 
    nomeCompleto: nome + ' ' + sobrenome
  }
}
var nomeETamanho = nomeCompletoETamanho('Lila', 'Oliveira');
console.log(nomeETamanho.nomeCompleto);
console.log(nomeETamanho.tamanho);

//https://pt.stackoverflow.com/q/403330/101
