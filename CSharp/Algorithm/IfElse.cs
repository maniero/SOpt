@if (item.Recursos == "Usuario") {
    <p style="font-size: 14px; font-weight:bold;">Usuario Criado:</p>
    @Html.EditorFor(model => model.UsuarioCriado, new { htmlAttributes = new { @class = "form-control" } })
} else if (item.Recursos == "E-mail") {
    <p style="font-size: 14px; font-weight:bold;">E-mail Criado:</p>
    @Html.EditorFor(model => model.EmailCriado, new { htmlAttributes = new { @class = "form-control" } })
} else if (item.Recursos == "Desktop" || item.Recursos == "Desktop (Novo") {
    <p style="font-size: 14px; font-weight:bold;">Nome do Desktop:</p>
    @Html.EditorFor(model => model.NomeDesktop, new { htmlAttributes = new { @class = "form-control" } })
} else if (item.Recursos == "Notebook")
    <p style="font-size: 14px; font-weight:bold;">Nome do Notebook:</p>
    @Html.EditorFor(model => model.NomeNotebook, new { htmlAttributes = new { @class = "form-control" } })
}

//https://pt.stackoverflow.com/q/404299/101
