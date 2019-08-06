function f(nome, obj) {
    with (obj) {
        console.log(nome);
    }
}

var o = objeto_de_nome_muito_grande_mas_que_nao_deveria_ter_sido_nomeado_assim;
console.log(o.nome);

with({o:objeto_de_nome_muito_grande_mas_que_nao_deveria_ter_sido_nomeado_assim}){
    console.log(o.nome);
};

with({f:open("x.txt")}){
    var data = f.read(1);
}

//https://pt.stackoverflow.com/q/52604/101
