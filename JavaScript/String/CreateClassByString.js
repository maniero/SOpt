class MinhaClasse{
    meuMetodo() {
        alert('Método Funciona!');
    }
}

let nome_classe = 'MinhaClasse';
let nome_metodo = 'meuMetodo';

var obj = eval("new " + nome_classe + "()");
obj[nome_metodo]();

//https://pt.stackoverflow.com/q/429796/101
