public class Program {
	public static void Main() 	{
		var html = @"< !DOCTYPE html >
            <html lang = ""pt_BR""> 
            <head> 
            <meta charset = ""utf-8"">
            <meta http-equiv = ""X-UA-Compatible"" content = ""IE=edge"">
            <meta name = ""viewport"" content = ""width=device-width, initial-scale=1"">
            <title> Aviso de Produto</title>
            <link rel = ""stylesheet"" href = ""http://netdna.bootstrapcdn.com/bootstrap/3.3.1/css/bootstrap.min.css""> 
            <script src = ""http://imsky.github.com/holder/holder.js""></script> 
            </head>
            <body>
             <div class=""container"">
            <hr/>
            <h2>Aviso de Produto</h2>
            <div class=""row"">
            <div id = ""items-list"" class=""col-xs-8"">
            <div class=""media"">
            <a class=""media -left"" href=""#"">
            <img alt = ""64x64"" width=""150"" height=""100""  src=""http://media.webdevacademy.com.br/2014/02/placeholder.jpg"">
            </a>
            <div class=""media-body"">
             <h4 class=""media-heading"">Titulo</h4>
             Cras sit amet nibh libero, in gravida nulla.Nulla vel metus scelerisque ante sollicitudin commodo. Cras purus odio, vestibulum in vulputate at, tempus viverra turpis.Fusce condimentum nunc ac nisi vulputate fringilla.Donec lacinia congue felis in faucibus.
            </div>
            </div>
             </div>
            </div>
            <hr/>
            <footer class""footer-inverse"">
             <div class=""container"">
            <p class=""text-muted"">&copy;2017 - Modelo Exemplo Onofre.</p>
             </div>
             </footer>
             <script src = ""https://ajax.googleapis.com/ajax/libs/jquery/1.11.0/jquery.min.js""></script> 
             <script src = ""http://netdna.bootstrapcdn.com/bootstrap/3.3.1/js/bootstrap.min.js""></script> 
             </body>
            </html>";
		System.Console.WriteLine(html);
	}
}

//http://pt.stackoverflow.com/q/191611/101
