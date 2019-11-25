function caloriasDeTrote(numeroDeVoltas) { 
    var calorias = 0; 
    for (var i = 1; i <= numeroDeVoltas; i++) calorias += 5 * i;
    return calorias; 
}
console.log(caloriasDeTrote(2));

//https://pt.stackoverflow.com/q/423186/101
