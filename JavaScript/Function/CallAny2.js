function funcao1(cb) {
  return cb();
}

var message = "ok";

function funcao2() {
  console.log(message);
}

funcao1(funcao2);

//https://pt.stackoverflow.com/q/470439/101
