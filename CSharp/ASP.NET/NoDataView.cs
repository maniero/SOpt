return new EmptyResult();

@model IEnumerable<ProcedimentoOcupacaoRegistro>

@if (Model.Count() > 0) {
    ...
} else {
    <div>Não tem itens pra mostrar</div>
}

return RedirectToAction("Error", "Relatorio");

return JavaScript( "alert('Nada a mostrar');" );

return View("SemDadosView");

//https://pt.stackoverflow.com/q/214887/101
