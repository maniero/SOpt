class Animal {
    constructor(raca) {
        this._raca = raca;
    }
    get raca() {
        return this._raca;
    }
}

class Cachorro extends Animal {}

var x = new Cachorro();
console.log(x.raca);

class Animal {
    constructor(raca) {
        this._raca = raca;
    }
    get raca() {
        return this._raca;
    }
}

class Cachorro extends Animal {
    constructor(raca) { super(raca) }
}

var x = new Cachorro("raça");
console.log(x.raca);

//https://pt.stackoverflow.com/q/400295/101
