var texto = $"Contei {x} vezes";
var texto = string.Format("Contei {0} vezes", x);

var idade = 25;
var exemplo = GetLocalText("My age is"); //retorna o texto "Minha idade é {idade}"
var texto = $exemplo; //isto não funciona, não é um literal.

var idade = 25;
var exemplo = GetLocalText("My age is"); //retorna o texto acima
var texto = string.Format(exemplo, idade); //produzirá "Minha idade é 25".

@Html.ActionLink("Hello " + User.Identity.GetUserName() + "!", "Index",
    "Manage", routeValues: null, htmlAttributes: new { title = "Manage" })

<a asp-controller="Manage" asp-action="Index" title="Manage">Hello @User.GetUserName()!</a>

//https://pt.stackoverflow.com/q/91117/101
