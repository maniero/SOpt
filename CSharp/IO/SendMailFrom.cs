var body = "<p>Email From: {0} ({1})</p><p>Message:</p><p>{2}</p>";
var message = new MailMessage();
message.From = new MailAddress("sender@email.com", "Nome Nome");
message.To.Add(new MailAddress("you@email.com"));
message.Subject = "Teste Subject";
message.Body = string.Format(body);
message.IsBodyHtml = true;
using (var smtp = new SmtpClient()) {
    await smtp.SendMailAsync(message);
}

//https://pt.stackoverflow.com/q/229713/101
