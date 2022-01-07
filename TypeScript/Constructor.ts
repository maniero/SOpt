class Classe {
    constructor(obj: any) {
        if (obj instanceof Array) {
            //faz algo
        } else {
            //faz outra coisa
        }
    }
}

class Classe {
    constructor(obj: boolean | number) {
        if (typeof obj === "boolean") {
            //faz algo
        } else {
            //faz outra coisa
        }
    }
}

//https://pt.stackoverflow.com/q/158075/101
