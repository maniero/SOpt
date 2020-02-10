function pascal(n) {
    var uau = "";
    for (var line = 1, d = 1; line <= n; line++) {
        for (var i = 1; i <= line; i++) {
            uau += d.toString();
            d *= (line - i) / i;
        }
        uau += "<br>";
    };
    return uau;
}
console.log(pascal(10));

//https://pt.stackoverflow.com/q/434964/101
