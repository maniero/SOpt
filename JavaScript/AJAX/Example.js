var req = new XMLHttpRequest();
req.onreadystatechange = function() {
    if (req.readyState == 4 && req.status == 200) {
       // faz alguma coisa;
    }
    req.open("GET", "pagina.php", true);
    req.send();
}

//https://pt.stackoverflow.com/q/90095/101
