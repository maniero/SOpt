var obj = {
    a : 1
};
console.log(obj.a);
console.log(obj.b);
if (obj.b == undefined) console.log("propriedade não existe");
obj.b = 2;
console.log(obj.b);
for (var chave in obj) console.log(chave + " = " + obj[chave]);

//https://pt.stackoverflow.com/q/161439/101
