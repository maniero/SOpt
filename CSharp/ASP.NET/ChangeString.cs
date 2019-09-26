<span class="pull-left text-success"><strong>Qtde.:</strong> {0}</span>
<span class="pull-right">{1}</span></br></br>
<span class="pull-right"><strong>Mesa:</strong></span><span class="pull-higlight">{2}</span>
<span class="pull-right">{3}</span></br></br>

var sIdentMesa = "";
if (objComandaParametro.ComandaParametros[0].IsUtilizaNrMesa) { 
    sIdentMesa = nrMesa;
}

btnFinalizaPreparo.Text = String.Format(btnFinalizaPreparo.Text, qtde, sIdentComanda, sIdentMesa, IdentNomeHorario, idProduto, nomeProduto, complemento);

//https://pt.stackoverflow.com/q/82871/101
