let array7 = new Array;
for (let x = 0; x < 50; x++) array7[x] = Math.floor(Math.random() * 50 - 10 + 10);
let array8 = array7.filter(array7 => array7 < 20)
console.log(array7.join(", "));
console.log(array8.join(", "));

//https://pt.stackoverflow.com/q/416301/101
