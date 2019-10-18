function foreach(array, func) {
    for (let key in array) func(array[key], key);
}
function imprimir(nome, indice) {
    console.log(`${indice + 1}. ${nome}`);
}
const carros = ['Mercedes', 'Ferrari', 'BMW'];
foreach(carros, imprimir);

const carros = ['Mercedes', 'Ferrari', 'BMW'];
for (let indice in carros) console.log(`${indice + 1}. ${carros[indice]}`);

//https://pt.stackoverflow.com/q/416286/101
