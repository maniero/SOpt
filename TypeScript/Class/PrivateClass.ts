module Modulo {
    export class ClassePublica {
        private classePrivada : PrivateClass;
        constructor() {
            this.classePrivada = new ClassPrivada();
        }
        public teste() {
            this.classePrivada.teste();
        }
    }
    class ClassPrivada {
        public teste() {
            console.log('it works');
        }
    }
}

//https://pt.stackoverflow.com/q/328202/101
