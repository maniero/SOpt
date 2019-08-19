function converte(letras) {
	let alfabeto = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
	let codigos = [];
	for (let i in letras) codigos.push(alfabeto.indexOf(removeAcento(letras[i].toUpperCase())) + 1);
	return codigos;
}

function removeAcento(letra) {
    let acentos = {
    "ÁÅÃÀÂÄ" : "A",
    "ÉÊÈË" : "E",
    "ÍÎÌÏ" : "I",
    "ÓÕÒÔÖ" : "O",
    "ÚÙÛÜ" : "U",
    "Ç" : "C"
    };
    for (let key in acentos) {
        for (var a = 0; a < key.length; a++) if (letra === key[a]) return acentos[key];
    }
    return letra;
}

let resultado = converte("acdAé");
for (let i in resultado) print(resultado[i]);

//https://pt.stackoverflow.com/q/54414/101
