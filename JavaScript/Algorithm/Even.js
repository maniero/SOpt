function pares() {
    var num1 = parseInt(document.getElementById("num1").value)
    for (num1 -= num1 % 2; num1 > 0; num1 -= 2) document.getElementById("resp").innerHTML += num1 + "<br>";
}
<input type="number" id="num1" placeholder="Informe o primeiro número: ">
<button onclick = "pares()">Numeros Pares</button>
<div id="resp"></div>

//https://pt.stackoverflow.com/q/286549/101
