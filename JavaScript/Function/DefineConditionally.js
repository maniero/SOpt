if (a > 1) {
    Save();
} else {
    NoSave();
}

var salvar;
if (a > 1) {
    salvar = function() { /*faz alguma coisa que seria o você quer no Save() */ };
} else {
    salvar = function() { /*faz outra coisa ou eventualmente não faz nada, seria o NoSave() */ };
}

//https://pt.stackoverflow.com/q/52162/101
