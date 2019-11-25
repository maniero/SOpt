function saldoDeMesesComLucro(umPeriodo) {
    var somas = [];
    for (var i = 0, j = 0; i < umPeriodo.length; i++) {
        if (umPeriodo[i] > 0) {
            somas.push(umPeriodo[i] + (j == 0 ? 0 : somas[j - 1]));
            j++;
        }
    }
    return somas;
}
console.log(saldoDeMesesComLucro([0, 1, 2, 0, 3, 4, 0, 5, 0, 0, 6]));

//https://pt.stackoverflow.com/q/423262/101
