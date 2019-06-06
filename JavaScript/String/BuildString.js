function gerarLista(lista) {
    var array = new Array(lista.length);
    for (var i = 0; i < lista.length; i++) {
        array[i] = `<div class="item">
            <div class="descricao">${lista[item].descricao}</div>
            <div class="imagem">
            <img src="${lista[item].imagem}" />
            </div>';
            <div class="valor">${lista[item].valor}</div>
            </div>`;
    }
    $("#produtos").html(array.join(""));
}

//https://pt.stackoverflow.com/q/389201/101
