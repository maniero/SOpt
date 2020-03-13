appendFooter(s);
appendFooter(StringBuffer report)

Parâmetro de entrada
void metodo(int x) {
    print x;
}
void metodo(array x) {
    x[0] = 1;
}
void metodo(const array x) {
    x[0] = 1;
}
void metodo(out int x) {
    x = 1;
}

var int a;
metodo(a);
print a; //imprimirá 1

//https://pt.stackoverflow.com/q/157927/101
