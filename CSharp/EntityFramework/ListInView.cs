public ActionResult ListarProduto() => new DBModels().View(db.Produto.ToList());

//https://pt.stackoverflow.com/q/432390/101
