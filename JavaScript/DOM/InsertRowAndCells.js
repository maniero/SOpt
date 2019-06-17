function table() {
    let max = 100;
    let table = document.getElementById('tableNumber');
    let linha;
    for (let i = 0; i < max; i++) {
        if (i % 10 == 0) linha = table.insertRow();
        linha.insertCell().appendChild(document.createTextNode(i + 1));
    }
}
table();

<table id = "tableNumber"></table>

//https://pt.stackoverflow.com/q/391395/101
