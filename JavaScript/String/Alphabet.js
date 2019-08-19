function converte(letras) {
	var alfabeto = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
	var codigos = [];
	for (let i in letras) {
		codigos.push(alfabeto.indexOf(letras[i].toUpperCase()) + 1);
	}
	return codigos;
}

var resultado = converte("acdA");
for (let i in resultado) {
    console.log(resultado[i]);
}

//https://pt.stackoverflow.com/q/54414/101
