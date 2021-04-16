protected IDbContext GameDbContext {get;}
protected virtual void Dispose(bool disposing) {
    if (!disposedValue) {
        if (disposing) GameDbContext.Dispose();
        disposedValue = true;
    }
}
public void Dispose => Dispose(true);

//https://pt.stackoverflow.com/q/505287/101
