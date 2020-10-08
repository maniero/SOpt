function op(s, v1, v2) {
    const v1Number = parseInt(v1, 2);
    const v2Number = parseInt(v2, 2);
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

op('+', '00000001', '00000011');

//https://pt.stackoverflow.com/q/475527/101
