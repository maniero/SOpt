const tabela = [ { min : 15.45, max : 15.5 },
                 { min : 15.5, max : 15.55 },
                 { min : 15.55, max : 16 },
                 { min : 16, max : 16.15 },
                 { min : 16.15, max : 16.2 } ];
var input = 16.16;
var valor = 0;
for (var i = 0; i < tabela.length; i++) {
    if (input >= tabela[i].min && input < tabela[i].max) {
        valor = tabela[i].max;
        break;
    }
}
console.log(valor);

https://pt.stackoverflow.com/q/495755/101
