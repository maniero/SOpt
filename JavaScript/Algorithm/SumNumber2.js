var dinheiro = [];
var total = 0;
function depositar() {
    var valor = parseInt(document.getElementById("txt").value)
    total += valor;
    dinheiro.push(valor); //somente se for fazer algo com este valor depois
    document.getElementById("dep").innerHTML += valor + "<br>";
}
function verConta() {
    document.getElementById("ex").innerHTML = total;
    document.getElementById("dep").innerHTML = "";
}
<!DOCTYPE html>
    <head>
        <title>banco</title>
    </head>
    <body>
        <h1 style="float: left;">No Caixa:</h1><h1 id="ex" style="float: left;">0</h1>
        </br></br></br></br></br>
        <input id="txt" type="number">
        <button onclick="depositar()">Depositar</button>
        <button onclick="verConta()">ver Conta</button>
        <p id="dep"></p>
    </body>
</html>

//https://pt.stackoverflow.com/q/273586/101
