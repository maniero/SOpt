public static void Inserir(Usuario usuario) {
    using var oDB = new estoqueDataClassesDataContext(); //para fazer o dispose correto
    oDB.Usuarios.InsertOnSubmit(usuario);
    oDB.SubmitChanges();
}

try {
    Inserir(usuario);
} catch (AlgumaExcecaoEspecificaAqui ex) { //não capture Exception
    MessageBox.Show(ex.Message); //você pode caprichar mais.
}

public static string Inserir(Usuario usuario) {
    try {
        var oDB = new estoqueDataClassesDataContext();
        oDB.Usuarios.InsertOnSubmit(usuario);
        oDB.SubmitChanges();
    } catch (AlgumaExcecaoEspecificaAqui ex) {
        return ex.Message;
    } finally {
        if (oDB != null) ((IDisposable)oDB).Dispose();
    }
    return "Tudo ocorreu ok";
}

MessageBox.Show(Inserir(usuario));

public static bool Inserir(Usuario usuario, out string nensagem) {
    try {
        var oDB = new estoqueDataClassesDataContext();
        oDB.Usuarios.InsertOnSubmit(usuario);
        oDB.SubmitChanges();
    } catch (AlgumaExcecaoEspecificaAqui ex) {
        menssagem = ex.Message;
        return false;
    } finally {
        if (oDB != null) ((IDisposable)oDB).Dispose();
    }
    mensagem = "Tudo ocorreu ok";
    return true;
}

if (Inserir(usuario, out mensagem)) MessageBox.Show(mensagem);
else {
    //faz outra coisa aqui que não seja só mostrar a mensagem, para fazer sentido
}

public static (bool, string) Inserir(Usuario usuario) {
    try {
        var oDB = new estoqueDataClassesDataContext();
        oDB.Usuarios.InsertOnSubmit(usuario);
        oDB.SubmitChanges();
    } catch (AlgumaExcecaoEspecificaAqui ex) {
        return (false, ex.Message);
    } finally {
        if (oDB != null) {
            ((IDisposable)oDB).Dispose();
        }
    }
    return (true, "Tudo ocorreu ok");
}

var (ok, mensagem) = Inserir(usuario); //talvez tenha uma forma mais conveniente
if (ok) MessageBox.Show(mensagem);
else {
    //faz outra coisa aqui que não seja só mostrar a mensagem, para fazer sentido
}

//https://pt.stackoverflow.com/q/170663/101
