function area(largura, altura) {
    const area = largura * altura;
    if (area > 20) {
       // Ou retornas false ou null
       console.log(`O valor acima do permitido: ${area}m2.`);
       return false;
    } else {
       return area;
    }
}

console.log(area(5, 5) + 1);

//https://pt.stackoverflow.com/q/474321/101
