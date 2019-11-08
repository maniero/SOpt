document.getElementById('note').innerHTML="<font class='ajax'><input type='hidden' name='star' id='star' value='" + id + "'></font>";
for (var i = 0; i < id; i++) {
    document.getElementById(i + 1).src = "../img/star1_48x48.png";
}

var textos = ["Detestei", "Não gostei", "Razoável", "Gostei", "Adorei"];
var user = document.getElementById('idLogged').value;
if (user != "") {
    document.getElementById('voto').value = id;
    document.getElementById('msg').innerHTML="<div class='alert alert-danger' style='height:48px;text-align:center;'>" + texxtos[id - 1] + "</div>";
} else {
    document.getElementById('msg').innerHTML="<div class='alert alert-danger' style='height:48px;text-align:center;'><strong>Erro ao avaliar!</strong> É necessário realizar o login para enviar um comentário.</div>";
}

//https://pt.stackoverflow.com/q/104100/101
