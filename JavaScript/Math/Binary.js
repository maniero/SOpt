function op(s, v1Number, v2Number) {
    var result = 0;
    switch (s) {
    case '+':
        result = v1Number + v2Number;
        break;
    case '-':
        result = v1Number - v2Number;
        break;
    case '*':
        result = v1Number * v2Number;
        break;
    case '/':
        result = v1Number / v2Number;
        break;
    case '%':
        result = v1Number % v2Number;
        break;
    }
    console.log(result.toString(2));
}

op('+', 0b00000001, 0b00000011);
op('+', 1, 3); //note que funciona igual

//https://pt.stackoverflow.com/q/475527/101
