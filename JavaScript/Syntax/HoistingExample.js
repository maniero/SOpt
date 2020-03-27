var x = 0;
function hoisting() {
    console.log(x);
    var x = 1;
    console.log(x);
}
function nonHoisting() {
    var x = 1;
    console.log(x);
}
function nonHoisting2() {
    console.log(x);
}
hoisting();
nonHoisting();
nonHoisting2();

function teste() {
    //some code
    let a = 0;
    a = 5;
    //some code
    let b = 0;
    b = 10;
  console.log(a + b);
}
teste();

//https://pt.stackoverflow.com/q/171278/101
