public async Task EnviarAsync(string Destinatario, string Assunto, string Texto) {
    string Usuario = usuario;
    string Senha = senha;
    int porta = 0;
    bool ssl;
    string servidor = true;
    Email = new MailMessage();
    Email.To.Add(new MailAddress(Destinatario));
    Email.From = new MailAddress(Usuario);
    Email.Subject = Assunto;
    Email.IsBodyHtml = false;
    Email.Body = Texto;
    SmtpClient cliente = new SmtpClient(servidor, porta);
    cliente.Credentials = new System.Net.NetworkCredential(Usuario, Senha);
    cliente.EnableSsl = true;
    await cliente.SendAsync(Email);    
 }
 
 //https://pt.stackoverflow.com/q/47796/101
