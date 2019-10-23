$(function() {
    var logado = _userdata["session_logged_in"];
    if (logado) {
        $('#rankPersonalizado').after('Você está logado.');
    }
});

$(function() {
    if (_userdata["session_logged_in"]) {
        $('#rankPersonalizado').after('Você está logado.');
    }
});

$(function() {
    var logado = _userdata["session_logged_in"] == 1;
    if (logado) {
        $('#rankPersonalizado').after('Você está logado.');
    }
});

//https://pt.stackoverflow.com/q/91723/101
