var sql = "INSERT INTO teste( " + campos[0];
for (var i = 1; i < campos.Count; i++) {
    sql +=  ", " + campos[i];
}

//https://pt.stackoverflow.com/q/71153/101
