<!DOCTYPE html>
<html>
<title>Conversor</title>
<body>

<h2>Conversor</h2>
<p>Conversor:</p>

<p>
  <label>valor</label>
  <input id = "inputValor" type = "number" placeholder = "valor" oninput = "Conversor(this.value)" onchange = "Conversor(this.value)">
</p>
<p>Resultado: <span id = "outputValor"></span></p>

<script>
function Conversor(valNum) {
    var gre = valNum >= 200 ? 4 : 2;
    var add = valNum >= 200 ? 4 : 0;
    var add2 = valNum >= 400 ? 4 : 0;
    document.getElementById("outputValor").innerHTML = valNum * gre + add + add2;
}

</script>
</body>
</html>

//https://pt.stackoverflow.com/q/387177/101
