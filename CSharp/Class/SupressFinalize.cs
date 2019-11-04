public class MyClass : IDisposable {
    private bool disposed = false;
    protected virtual void Dispose(bool disposing) {
        if (!disposed) {
            if (disposing) {
                // chamado pelo myClass.Dispose(). 
                // OK usar quaisquer referências para objetos privados
            }
            disposed = true;
        }
    }

    public void Dispose() { // necessário para a interface IDisposable
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    ~MyClass() { //método finalizador (destrutor)
        Dispose(false);
    }
}

//https://pt.stackoverflow.com/q/102609/101
