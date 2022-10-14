texto= "Aqui tem uma barra\\ e \" também";
var novoTexto = "";
for (var i = 0; i < texto.length; i++) if (texto[i] !== "\"" && texto[i] !== "\\") novoTexto += texto[i];
console.log(novoTexto);

//https://pt.stackoverflow.com/q/27980/101
