function calculos(valores) {
    return [valores.filter(nr => nr < 0).length / valores.length * 100, valores.filter(nr => nr == 0).length / valores.length * 100, valores.filter(nr => nr > 0).length / valores.length * 100];
}
console.log(calculos([-1, 0, 1, 0, 2, -2]));

//https://pt.stackoverflow.com/q/413277/101
