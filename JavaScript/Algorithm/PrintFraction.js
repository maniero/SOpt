for (let numerador = 480, denominador = 10; denominador < 41; numerador -= 5, denominador++) {
    console.log((denominador % 2 == 0 ? "+" : "-") + numerador);
    console.log("----");
    console.log(" " + denominador);
    console.log("\n");
}

//https://pt.stackoverflow.com/q/415861/101
