<input type="hidden" name="NomeDoFormulario" value="InformacaoAdicional">

<button type="submit" name="meuForm" value="true">Enviar</button>

//PHP:

if (isset($_POST["meuForm"])) {
    //faz alguma coisa
}

//https://pt.stackoverflow.com/q/44764/101
