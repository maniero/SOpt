function totalSum(a) {
  let total = 0;
  let contador = 0;
  for (const elem of a) {
      for (const subElem of elem) {
          total += subElem;
          contador++;
      }
  }
  console.log(contador);
  return total;
}

// Exemplo de entrada:
totalSum([[1, 2], [3, 4]]); // 10

//https://pt.stackoverflow.com/q/429553/101
