var objeto = [ 1, 2 ];
for (var chave in objeto) console.log(objeto[chave]);

for (var chave in objeto) if (objeto.hasOwnProperty(chave)) console.log(objeto[chave]);

objeto.forEach(function(valor, indice) {
    console.log(valor);
});

//https://pt.stackoverflow.com/q/90608/101
