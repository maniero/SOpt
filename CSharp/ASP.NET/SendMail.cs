public bool Mail(MailAddress to, MailAddress from, string sub, string body) {
    var me = new EmailBusiness();
    var m = new MailMessage() {
        Subject = sub,
        Body = body,
        IsBodyHtml = true
    };
    to = new MailAddress("endereço@de.email", "Nome");
    m.To.Add(to);
    m.From = new MailAddress(from.ToString());
    m.Sender = to;
    var smtp = new SmtpClient {
        Host = "url.do.servidor",
        Port = 587,
        Credentials = new NetworkCredential("usuario", "senha"),
        EnableSsl = true
    };
    try {
        smtp.Send(m);
    } catch (Exception e) { //não faça isto, por favor, é só um exemplo
        return false
    }
    return true;
}

//https://pt.stackoverflow.com/q/84239/101
