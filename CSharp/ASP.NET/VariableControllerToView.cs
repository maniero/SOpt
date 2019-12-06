[HttpPost]
public void Attempt(string email, string password, Admins db) {
    Admins admin = db.admins.Where(model => model.email == email).FirstOrDefault(); 
    ViewBag.Error = "test1"; //ou ViewData["Error"] = "test1";
    return View();
}

@ViewBag.Error
ou @ViewData["Error"]

//https://pt.stackoverflow.com/q/115023/101
