function dec2bin(dec) {
    return dec >= 0 ? dec.toString(2) : (~dec).toString(2);
}
console.log(dec2bin(47));
console.log(dec2bin(-47));


function dec2bin(dec) {
    var binario = dec >= 0 ? dec.toString(2) : (~dec).toString(2);
    var tamanho = binario.length > 32 ? 64 : binario.length > 16 ? 32 : binario.length > 8 ? 16 : 8;
    return ("0".repeat(tamanho) + binario).substr(-tamanho);
}
console.log(dec2bin(47));
console.log(dec2bin(-47));
console.log(dec2bin(12347));
console.log(dec2bin(5612347));

//https://pt.stackoverflow.com/q/163246/101
