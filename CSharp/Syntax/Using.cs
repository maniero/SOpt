{
    FileStream fs = new FileStream("abc.txt", FileMode.Create);
    try {
       // Algum código...
    } finally {
        if (fs != null)
            ((IDisposable)fs).Dispose();
    }
}

//https://pt.stackoverflow.com/q/145858/101
