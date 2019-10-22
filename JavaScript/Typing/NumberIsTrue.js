$(function() {
    var logado = _userdata["session_logged_in"];
    if (logado) {
        $('#rankPersonalizado').after('Você está logado.');
    }
});

Se não for usar esta variável local em outros lugares do código (no momento não está usando) e quiser simplificar:

$(function() {
    if (_userdata["session_logged_in"]) {
        $('#rankPersonalizado').after('Você está logado.');
    }
});

Se não tiver controle sobre o valor desta variável "global" que indica se o usuário está logado, ainda pode transformar em booleano nas demais operações:

$(function() {
    var logado = _userdata["session_logged_in"] == 1;
    if (logado) {
        $('#rankPersonalizado').after('Você está logado.');
    }
});

//https://pt.stackoverflow.com/q/91723/101
