public void geraLista() {
    cursor.moveToLast();
    int x = cursor.getCount();
    for(int y = 1; y < x; y++){
        //nextdado();   
        tabelas.Add(retornadado());   
        dadoanterior();
    };
    return tabelas;
}

//https://pt.stackoverflow.com/q/39335/101
