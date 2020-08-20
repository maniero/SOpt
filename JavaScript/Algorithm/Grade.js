function teste() {
    var t1 = prompt("Nota da ap1");
    if (isNaN(t1)) return;
    var t2 = prompt("Nota da ap2");
    if (isNaN(t2)) return;
    var ap3questoes = (5 - (parseFloat(t1) + parseFloat(t2)) * 0.3) / 0.16;
    document.write(ap3questoes * 0.4);
    document.write(" - ");
    document.write(Math.round(ap3questoes));
}
teste();

//https://pt.stackoverflow.com/q/351404/101
