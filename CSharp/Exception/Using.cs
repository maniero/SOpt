void Metodo() {
    using var http = new HttpClient();
    http.......
    ...
} // o recurso da variável http será liberado aqui

{
    HttpClient http = new HttpClient();
    try {
       // Algum código...
    } finally {
        if (http != null)
            ((IDisposable)http).Dispose();
    }
}

public void Dispose()
{
    Dispose(true);
    GC.SuppressFinalize(this);
}

protected virtual void Dispose(bool disposing)
{
    if (disposing && !_disposed)
    {
        _disposed = true;

        if (_disposeHandler)
        {
            _handler.Dispose();
        }
    }
}

~FileStream()
{
    // Preserved for compatibility since FileStream has defined a
    // finalizer in past releases and derived classes may depend
    // on Dispose(false) call.
    Dispose(false);
}

//https://pt.stackoverflow.com/q/422625/101
