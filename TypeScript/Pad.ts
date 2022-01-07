function teste() {
    var today = new Date();
    var dd = today.getDate();
    var mm = today.getMonth() + 1;
    var yyyy = today.getFullYear();
    var d = dd.toString().padStart(2, '0');
    var m = mm.toString().padStart(2, '0');
    console.log(d);
    console.log(m);
}
teste();

//https://pt.stackoverflow.com/q/360853/101
