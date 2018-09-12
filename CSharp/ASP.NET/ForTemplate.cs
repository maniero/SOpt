var valor = 0M;
@foreach (var i = 0; i < model.Count(); i++) {
    <tr>
        <td>Id</td>
        <td>Nome</td>
        <td>Valor</td>
    </tr>
    valor += model[i].Valor;
    var proximoID = model[i + 1].Id;
}

//https://pt.stackoverflow.com/q/321177/101
