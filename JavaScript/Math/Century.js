function centuryFromYear(year) {
    if (year == 1) return 1;
    if (year > 2101 || year < 1) return null;
    return Math.trunc((year - 2) / 100) + 1;
}
console.log(centuryFromYear(-1));
console.log(centuryFromYear(0));
console.log(centuryFromYear(1));
console.log(centuryFromYear(50));
console.log(centuryFromYear(100));
console.log(centuryFromYear(101));
console.log(centuryFromYear(102));
console.log(centuryFromYear(150));
console.log(centuryFromYear(2000));
console.log(centuryFromYear(2100));
console.log(centuryFromYear(2200));

//https://pt.stackoverflow.com/q/354459/101
