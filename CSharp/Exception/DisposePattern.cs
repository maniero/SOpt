{
    var arq = new FileStream("arq.txt", FileMode.Create);
    try {
        //faz alguma coisa aqui
    } finally {
        if (arq != null) ((IDisposable)arq).Dispose();
    }
}

//https://pt.stackoverflow.com/q/300809/101
