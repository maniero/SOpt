int idade = 18;
string nome = "";

if (idade != 0) {
    var resultado = (from u in db.Usuario
            where u.Nome == nome && u.Idade == idade).ToList();
} else {
    var resultado = db.Usuario.ToList();
}

var resultado = (from u in db.Usuario
        where idade == 0 || (u.Nome == nome && u.Idade == idade)).ToList()
        
//https://pt.stackoverflow.com/q/82752/101
