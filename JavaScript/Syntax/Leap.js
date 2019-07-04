function calcularBissexto(){
    var bi = parseInt(document.getElementById('bissexto').value);
    var msg = document.getElementById('msg');
    if (bi % 4 == 0 && bi % 100 != 0 || bi % 400 == 0) msg.innerHTML += 'E bissexto'
    else msg.innerHTML+= 'Nao e bissexto';
}

//https://pt.stackoverflow.com/q/394953/101
