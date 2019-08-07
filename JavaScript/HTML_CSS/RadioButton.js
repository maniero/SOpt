function transformar(){  
    var converter = parseFloat(document.getElementById('converter').value);
    var resposta = document.getElementById('resposta');
    var resp = '';
    

    
    if(document.getElementById('celsius').checked){
        resp = (converter - 32) * (5/9);
    }
    if(document.getElementById('fahren').checked){
        resp = (converter * (9/5)+32);
    }
    resposta.innerHTML = resp;
}

<!DOCTYPE html>
<html lang="pt-br">
<head>
    <meta charset="UTF-8">
    <title>Temperatura</title>
    <script src="temperatura.js"></script>
</head>
<body>
    <form>
        Graus Celsius: <input type="radio" id="celsius" name="temperatura" value="Celsius">
        Graus Fahrenheit: <input type="radio" id="fahren" name="temperatura" value="Fahrenheit"> <br>
        Converter Valor: <input type="number" id="converter">
        <button onclick="transformar()">transformar</button><br>
        Resposta:
        <div id="resposta"></div>
    </form>
        
</body>
</html>

//https://pt.stackoverflow.com/q/402120/101
