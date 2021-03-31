function area(largura, altura) {
    const area = largura * altura;
    if (area > 20) {
        console.log(`O valor acima do permitido: ${area}m2.`);
    } else {
        return area;
    }
}

let resultado = area(5, 5);
if (resultado != undefined) console.log(resultado);
console.log(area(5, 5) + 1);
resultado = area(4, 5);
if (resultado != undefined) console.log(resultado);

//https://pt.stackoverflow.com/q/474321/101
