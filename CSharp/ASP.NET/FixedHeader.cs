<!DOCTYPE html>
<html>
    <head>
        <meta charset="utf-8">
        <title>@ViewBag.Title</title>  
        <link href="@Url.Content("~/Content/Site.css")" rel="stylesheet" type="text/css">
    </head>
    <body>
        <div id="header"> 
            Cabeçalho aqui           
        </div>
        <div id="main">
            @RenderBody()
        </div>
        <div id="footer"> 
            Rodapé aqui           
        </div>
    </body>
</html>

@{
    ViewBag.Title = "Titulo da página específica";
    Layout = "~/Views/Shared/_Layout.cshtml";
}
<h1>Esta página</h1>
<p>Conteúdo</p> <!-- só um exemplo simples -->

//https://pt.stackoverflow.com/q/83065/101
