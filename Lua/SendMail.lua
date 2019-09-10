-- load the smtp support
local smtp = require("socket.smtp")

from = "<coloque_o_seu_email_aqui_nao_use_o_de_outras_pessoas@xxx.com>"

rcpt = {
  "<coloque_um_email_aqui_nao_use_o_de_outras_pessoas@xxx.com>",
  "<coloque_um_email_aqui_nao_use_o_de_outras_pessoas@xxx.com>",
  "<coloque_um_email_aqui_nao_use_o_de_outras_pessoas@xxx.com>"
}

mesgt = {
 headers = {
   to = "Fulano da Silva <coloque_um_email_aqui_nao_use_o_de_outras_pessoas@xxx.com>",
   cc = '"Beltrano F. Nunes" <coloque_um_email_aqui_nao_use_o_de_outras_pessoas@xxx.com>',
   subject = "My first message"
},
body = "I hope this works. If it does, I can send you another 1000  copies."
}

r, e = smtp.send{
 from = from,
 rcpt = rcpt, 
 source = smtp.message(mesgt)
 user = "usuario_valido_em_algum_servidor_de_email_que+voce_tenha_acesso",
 password = "senhaqui",
 server = "servidor_smtp_onde_voce_tenha_acesso_smtp.google.com_por_exemplo",
 port = 465, -- pode ser outra porta
 create = sslCreate
}

--https://pt.stackoverflow.com/q/74388/101
