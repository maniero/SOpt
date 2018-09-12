function foo() {
    var x = 1;
    var y = 3;
    if (true) {
        var x = 2;
        var y_1 = 4;
        console.log(x);
        console.log(y_1);
    }
    console.log(x);
    console.log(y);
}

//https://pt.stackoverflow.com/q/323697/101
