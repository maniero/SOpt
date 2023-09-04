class Mamifero {
    constructor(especie, genero, patas) {
        this.especie = especie;
        this.genero = genero;
        this.patas = patas;
    };
};

class Lobo extends Mamifero {
    constructor(especie, genero, patas, raca, cor) {
        super(especie, genero, patas);
        this.raca = raca;
        this.cor = cor;
    };
};
let loboCinza = new Lobo("Canis Lupus", "Macho", 4, "Lobo Cinzento", "Cinza");
console.log(loboCinza instanceof Mamifero);
let lobo = new Mamifero("Canis Lupus", "Macho", 4);
console.log(lobo instanceof Mamifero);
console.log(Lobo instanceof Mamifero);
console.log(Mamifero instanceof Mamifero);
console.log(new Lobo instanceof Mamifero);
console.log((new Lobo) instanceof Mamifero);
console.log((new Mamifero) instanceof Mamifero);
console.log(Lobo instanceof Object);

//https://pt.stackoverflow.com/q/586197/101
