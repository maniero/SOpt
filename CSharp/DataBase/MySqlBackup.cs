using (MySqlConnection conn = new MySqlConnection(connectionString))
using (MySqlCommand cmd = new MySqlCommand())
using (MySqlBackup mb = new MySqlBackup(cmd)) {
    cmd.Connection = conn;
    conn.Open();
    mb.ExportInfo.EnableEncryption = true;
    mb.ExportInfo.EncryptionPassword = "qwerty";
    mb.ExportToFile(@"C:\backup.sql");
}

//https://pt.stackoverflow.com/q/48899/101
