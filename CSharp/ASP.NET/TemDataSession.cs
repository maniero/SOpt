TempData["Login"] = retorno.login;
TempData["senha"] = retorno.senha;
TempData["nome"] = retorno.nomeusuario;
TempData["id"] = retorno.idusuario;

Session["Login"] = retorno.login;
Session["senha"] = retorno.senha;
Session["nome"] = retorno.nomeusuario;
Session["id"] = retorno.idusuario;

//https://pt.stackoverflow.com/q/105806/101
