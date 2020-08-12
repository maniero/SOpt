[HttpPost]
[ValidateAntiForgeryToken]
public ActionResult Create([Bind(Include = "Id,Nome,Email,Senha")] Pessoa pessoa) {
    if (pessoa != null) {
        if (db.Pessoas.Where(w => w.Email == pessoa.Email).FirstOrDefault() != null) {                                        
            db.Pessoas.Add(pessoa);
            db.SaveChanges();
            return RedirectToAction("Index");
        } else {
            ModelState.AddModelError("", "E-mail já cadastrado");
            return View();
        }
    } else return View(pessoa);
}

//https://pt.stackoverflow.com/q/339201/101
