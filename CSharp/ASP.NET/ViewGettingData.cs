[HttpPost]
public ActionResult Login(string pUsuario, string pSenha) {
     usuario oUsuario = modelOff.usuarios.Where(p => p.usuario1 == pUsuario && p.senha == pSenha).SingleOrDefault();
     ViewBag.usuario = oUsuario == null ? "nao" : oUsuario.usuario1;
     return View();
}

//precisa colocar onde está o modelo aqui, mas na pergunta não tem a localização
@{
    ViewBag.Title = "Login";
}

<h2>Olá Fulano @ViewBag.usuario</h2>

[HttpPost]
public ActionResult Login(string pUsuario, string pSenha) {
     usuario oUsuario = modelOff.usuarios.Where(p => p.usuario1 == pUsuario && p.senha == pSenha).SingleOrDefault();
     ViewBag.usuario = oUsuario == null ? "nao" : oUsuario.usuario1;
     return View((object)(oUsuario == null ? "nao" : oUsuario.usuario1));
}

@model string
@{
    ViewBag.Title = "Login";
}

<h2>Olá Fulano @Model</h2>

//https://pt.stackoverflow.com/q/224882/101
