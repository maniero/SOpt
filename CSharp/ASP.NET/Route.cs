routes.MapRoute("Default", //nome da rota
                "{controller}/{action}/{id}", // padrão do URL
                new { controller = "Home", action = "Index", id = "" }  // parâmetros


public class HomeController : Controller {
    public ActionResult Index(string id) => View();
}


[Route(“{produtoId:int}”)]
public ActionResult Edita(int produtoId) => View();

//https://pt.stackoverflow.com/q/162142/101
