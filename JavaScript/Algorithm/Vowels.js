function lerLetra() {
    return prompt("Introduza uma letra");
}

function isVogal(caracter) {
    switch (caracter) {
        case "a":
        case "A":
        case "e":
        case "E":
        case "i":
        case "I":  
        case "o":
        case "O":
        case "u":
        case "U": 
            return true;
        default:
            return false;
    }
}

var letra = lerLetra();
if (isVogal(letra)) alert("A letra é vogal");
else alert("A letra é consoante");

alert("aeiouAEIOU".indexOf(prompt("Insira uma letra")) !== -1 ? "A letra é vogal" : "A letra é consoante");

//https://pt.stackoverflow.com/q/420662/101
