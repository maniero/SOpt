public ActionResult MinhaAction() {
    Session["relatorioX"] = MontaRelatorio();
    ...
}
public ActionResult OutraAction() => Json(Session["relatorioX"], JsonRequestBehavior.AllowGet);

//https://pt.stackoverflow.com/q/86693/101
