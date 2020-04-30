var a = {};

if (a && a.b && a.b.c) {
    console.log("definido!");
} else {
    console.log("indefinido!");
}

a = { b : { c: {} } };

if (a && a.b && a.b.c) {
    console.log("definido!");
} else {
    console.log("indefinido!");
}

//https://pt.stackoverflow.com/q/185447/101
