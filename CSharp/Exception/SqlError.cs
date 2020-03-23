public class Functions {
    public static void conn() {
        string connectionString = Conn.tank();
        var connection = new SqlConnection(connectionString);
        try {
            connection.Open();
            Globals.UpdateLogs("Conexão testada:");
            Globals.UpdateLogs("Status da Conexão : " + connection.State);
            Globals.UpdateLogs("User : " + connection.WorkstationId);
            Globals.UpdateLogs("Banco de dados : " + connection.Database);
            Globals.UpdateLogs("Versão SQL : " + connection.ServerVersion);
        } catch (SystemException ex) {
            if (ex is InvalidOperationException || ex is SqlException || ex is ConfigurationErrorsException) {
                Globals.UpdateLogs("O programa não está conectado em sua DataBase, verifique as configurações");
            }
        } finally {
            if (connection != null) {
                ((IDisposable)connection).Dispose();
            }
        }
    }
}

//https://pt.stackoverflow.com/q/165632/101
