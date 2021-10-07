char msg[1000];
printf("Escreva a mensagem para ser criptografada: ");
fgets(msg, sizeof(msg), stdin);
for (int i = msg; *i != '\0'; i++) *i = ((*i >= 'A' && *i <= 'Z') || (*i >= 'a' && *i <= 'z')) ? *i + 3 : *i;

//https://pt.stackoverflow.com/q/384750/101
