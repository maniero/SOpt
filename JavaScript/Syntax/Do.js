do { a = a[b]; } while (a && 1 !== a.nodeType);

do { //marca o ínico do laço
    a = a[b];  //faz o que tem que fazer
} while (a && a.nodeType !== 1); //só agora verificará se deve repetir

a = a[b];
while (a && a.nodeType !== 1) { //a condição é a mesma, só é executada em outro momento
    a = a[b];
} //aqui marca o fim, certamente voltará para o início para decidir se continuará

//https://pt.stackoverflow.com/q/218726/101
