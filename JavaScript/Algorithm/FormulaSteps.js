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
    valNum = parseInt(valNum); //não estou tratando se vai dar erro igual ao que foi feito antes
    document.getElementById("outputValor").innerHTML = (valNum * ((Math.trunc(valNum / 200) + 1) * 2)) + valNum + (Math.trunc(valNum / 200) * 4);
}

</script>
</body>
</html>

//https://pt.stackoverflow.com/q/387177/101
