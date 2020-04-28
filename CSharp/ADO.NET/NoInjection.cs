private static void UpdateDemographics(int customerID, string demoXml, string connectionString) {
    using (var connection = new SqlConnection(connectionString)) {
        var command = new SqlCommand("UPDATE Sales.Store SET Demographics = @demographics WHERE CustomerID = @ID;", connection);
        command.Parameters.Add("@ID", SqlDbType.Int);
        command.Parameters["@ID"].Value = customerID;

        command.Parameters.AddWithValue("@demographics", demoXml);

        try {
            connection.Open();
            WriteLine($"RowsAffected: {command.ExecuteNonQuery()}");
        } catch (Exception ex) { //só para facilitar, normalmente é se usa assim
            WriteLine(ex.Message);
        }
    }
}

public TB_USUARIO ListarPorLoginSenha(string login, string senha) { //esse retorno não parece certo
    var strQuery = @"select b.DESCRICAO as PERFIL, b.ADMINISTRADOR as ADMINISTRADOR, c.DATA_FIM as DATAFINALASSINATURA, c.SITUACAOASSINATURA, a.*
                      from TB_USUARIO a
                      inner join TB_PERFIL_ACESSO b on a.IDPERFIL = b.IDPERFIL
                      left join TB_ASSINATURA c on c.IDUSUARIO = a.IDUSUARIO
                      where a.login = @Login and a.senha = @Senha and a.USUARIOATIVO = 'S' and a.USUARIOEXCLUIDO = 'N'
                      order by a.IDUSUARIO";
    using (var conn = new SqlConnection(/* coloca aqui como pega a string */)) {
        var cmd = new SqlCommand(strQuery, conn);
        cmd.Parameters.Add(new SqlParameter("@Login", login));
        cmd.Parameters.Add(new SqlParameter("@Senha", senha));
        //a partir daqui eu não sei o que esse código faz, teria que adaptá-lo para usar o SQLCommand ou fazer de outra forma
        using (var contexto = new Contexto()) {
            return TransformaReaderEmListaObjetos(contexto.ExecutaComandoComRetorno(cmd)).FirstOrDefault();
        }
    }
}

//https://pt.stackoverflow.com/q/183975/101
