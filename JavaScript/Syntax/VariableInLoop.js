var G = [];
for (var i = 0; i < 3; i++) {
    G[i] = $('#G' + (i + 1)).text();
}
console.log("NaN");
var soma = 0;
for (var i = 0; i < 3; i++) {
    console.log(G[i] + "\n");
    soma += G[i];
}
console.log(soma)
for (var i = 0; i < 3; i++) {
    G[i] = parseFloat(G[i]);
}
console.log("Agora Números")
var soma = 0;
for (var i = 0; i < 3; i++) {
    console.log(G[i] + "\n");
    soma += G[i];
}
console.log(soma)

//https://pt.stackoverflow.com/q/255912/101

<script src="https://ajax.googleapis.com/ajax/libs/jquery/2.1.1/jquery.min.js"></script>

<p id="G1">10</p>
<p id="G2">20</p>
<p id="G3">30</p>
