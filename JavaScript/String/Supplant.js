String.prototype.concatenar = (a) => this + a;

String.prototype.supplant = function (o) {
    return this.replace(/\${([^{}]*)}/g,
        function (a, b) {
            var r = o[b];
            return typeof r === 'string' || typeof r === 'number' ? r : a;
        }
    );
};

console.log("Meu nome é ${nome}, e tenho ${idade} anos".supplant({ nome: "danilo", idade : 29 }));

//https://pt.stackoverflow.com/q/78750/101
