<!DOCTYPE HTML>
<html>
  <head>
    <title>Exercício 2</title>
    <meta charset="utf-8" />
    <script>
    function calcularMedia(){
        var soma = 0;
        var contador = 0;
        for(;;) {
            var nota = parseInt(prompt("Digite uma nota:"));
            soma += nota;
            contador++;
            var dec = parseInt(prompt("Deseja continuar? Digite 1 para 'SIM' ou 2 para 'NÃO':"));
            if (dec == 2) {
                alert('A média das notas digitadas é: ' + parseInt(soma / contador));
                break;
            }
        }
    }
    </script>
  </head>
  <body>
  <script>calcularMedia();</script>
  </body>
</html>

//https://pt.stackoverflow.com/q/392024/101
