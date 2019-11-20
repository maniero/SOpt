clazz.imprime = function() {
    alert("nome: " + nome + ", idade: " + idade);
}

clazz["imprime"] = function() {
    alert("nome: " + nome + ", idade: " + idade);
}

//https://pt.stackoverflow.com/q/108626/101
