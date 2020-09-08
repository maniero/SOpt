var objeto = { a: 'A', b: 'B', c: 'C' };
for (var i in objeto) console.log(objeto[i]);

var objeto = { a: "A", b: "B", c: "C" };
var obj = Object.entries(objeto);
const it = obj.values();
let entry;
while (!(entry = it.next()).done) console.log(entry.value[1]);
var objeto = [1, 2, 3];
for (var i of objeto) console.log(i);

var objeto = [1, 2, 3];
const it = objeto.values();
let entry;
while (!(entry = it.next()).done) console.log(entry.value);

var objeto = [1, 2, 3];
let i = 0;
while (i < objeto.length) console.log(objeto[i++]);

//https://pt.stackoverflow.com/q/471070/101
