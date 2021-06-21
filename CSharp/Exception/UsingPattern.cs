using (FileStream fs = new FileStream("abc.txt", FileMode.Create)) {
    // Algum código...
}

{
    FileStream fs = new FileStream("abc.txt", FileMode.Create);
    try {
       // Algum código...
    } finally {
        if (fs != null)
            ((IDisposable)fs).Dispose();
    }
}

using var fs = new FileStream("abc.txt", FileMode.Create);

//https://pt.stackoverflow.com/q/163768/101
