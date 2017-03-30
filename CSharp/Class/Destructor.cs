class Car {
    ~Car() { // destrutor
        // código de limpeza...
    }
}

//é o mesmo que

protected override void Finalize() {
    try {
        // código de limpeza...
    } finally {
        base.Finalize();
    }
}

//http://pt.stackoverflow.com/q/9078/101
