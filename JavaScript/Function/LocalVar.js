function calcImc() {
    var peso = document.getElementById('inPeso').value;
    var altura = document.getElementById('inAlt').value;
    alert("O IMC é " + (peso / (altura * altura)));
}

<!DOCTYPE html>
<html>
    <head>
        <title> IMC</title>
        <meta carset = "utf-8"/>
        <link rel="stylesheet" type="text/css" href="imc.css"/>
        <link rel="shortcut icon" type="image/x-icon" href="6551sans.ico"/>
        <script type="text/javascript" src="IMC.js"></script>
    </head>
    <body>
        <h1>Calcule seu IMC</h1>
        <form method="GET" id="formulario">
            <label>Peso</label>
            <input id ="inPeso" type="text" placeholder="Insira seu peso" size="20" maxlength="5">
            <label>Altura</label>
            <input id ="inAlt" type="text" placeholder="Insira sua altura (Ex.: 1.7)" size="25" maxlength="5">
            <label>Sexo</label>
            <input type="radio" class="inSexo" name="sexo" value ="m">
            <label>Masculino</label>
            <input type="radio" class="inSexo" name="sexo" value ="f">
            <label>Feminino</label>
            <button type="submit" accesskey="e" onclick="calcImc();">Calcular</button>
        </form>
    </body>
</html>

//https://pt.stackoverflow.com/q/389011/101
