function sequence(limite, incremento) {
    limite = incremento * Math.floor(limite / incremento);
    return (((limite / incremento) + 1) / 2) * limite;
}

function solution(number) {
    return sequence(number - 1, 3) + sequence(number - 1, 5) -  sequence(number - 1, 15);
}

console.log(solution(10));
console.log(solution(20));

//https://pt.stackoverflow.com/q/565371/101
