ViewBag.Ferias = funcionarioFeriasRepository.Lista.Where(r => r.CdMatricula == matricula && r.SqContrato == contrato && r.DtInicioConcessao == null)
        .Select(x => new { Inicio = x.DtInicioPeriodo, Fim = x.DtFimPeriodo}).ToList();

<div class="col-md-9">
    <select class="form-control" style="width:250px" id="selectPeriodo" name="sAquisitivo">
        @foreach (var date in ViewBag.Ferias) {
            <option>
                @Convert.ToDateTime(date.Inicio).ToShortDateString() à @Convert.ToDateTime(date.Fim).ToShortDateString()
            </option>
        }
    </select>
</div>

//https://pt.stackoverflow.com/q/49068/101
