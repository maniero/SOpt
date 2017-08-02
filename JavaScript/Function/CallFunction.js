var a = 0;
main = function(_this){
  console.log('Está entrando em Main');
  return function(){
    console.log("Retorno"); //Não escreve o retorno
    a++; //Não incrementa a variável
  };
}(this);
main();
console.log(a);

//https://pt.stackoverflow.com/q/224752/101
