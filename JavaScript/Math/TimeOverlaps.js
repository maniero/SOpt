function overlaps(x, y) {
    return Math.max(0, Math.min(x.fim, y.fim) - Math.max(x.inicio, y.inicio)) > 0;
}
var a = { inicio : new Date(2023, 2, 30, 10, 10, 10), fim : new Date(2023, 2, 30, 10, 10, 20) };
var b = { inicio : new Date(2023, 2, 30, 10, 10, 05), fim : new Date(2023, 2, 30, 10, 10, 15) };
var c = { inicio : new Date(2023, 2, 30, 10, 10, 05), fim : new Date(2023, 2, 30, 10, 10, 09) };
var d = { inicio : new Date(2023, 2, 30, 10, 10, 05), fim : new Date(2023, 2, 30, 10, 10, 10) };
var e = { inicio : new Date(2023, 2, 30, 10, 10, 20), fim : new Date(2023, 2, 30, 10, 10, 30) };
var f = { inicio : new Date(2023, 2, 30, 10, 10, 12), fim : new Date(2023, 2, 30, 10, 10, 18) };
console.log(overlaps(a, b));
console.log(overlaps(a, c));
console.log(overlaps(a, d));
console.log(overlaps(a, e));
console.log(overlaps(a, f));

//https://pt.stackoverflow.com/q/580723/101
