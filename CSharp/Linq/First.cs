var user = db.Usuario.FirstOrDefault(u => u.Nome == model.Nome && u.Senha.Equals(model.Senha));

if (user == null) return false;

//https://pt.stackoverflow.com/q/102086/101
