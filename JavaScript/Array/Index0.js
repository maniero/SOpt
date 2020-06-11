const funcs = [];
for (let i = 0; i < 10; i++) {
    funcs.push(function() {
        console.log(i);
    });
    console.log(funcs.length - 1, i);
}
console.log(funcs.length);
funcs[2]();
funcs[8]();

//https://pt.stackoverflow.com/q/456713/101
