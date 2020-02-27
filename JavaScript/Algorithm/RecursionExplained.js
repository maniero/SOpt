function foo(i) {
   console.log('entrei com valor i: ' + i);
   if (i < 0) {
      console.log('entrou no if e i: ' + i);
      return;
   }
   document.writeln('begin:' + i);
   console.log('chamará nova função e i: ' + i + ', então chamará com o valor ' + (i - 1));
   foo (i - 1);
   console.log('voltei pra função que estava e i: ' + i);
   document.writeln('end:' + i);
   console.log('estou encerrando a função e i: ' + i);
}
console.log('vou começar');
foo(2);
console.log('terminei');

//https://pt.stackoverflow.com/q/437017/101
