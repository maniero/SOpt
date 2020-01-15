function Container(param) {
    function dec() {
        if (secret > 0) {
            secret -= 1;
            return true;
        } else {
            return false;
        }
    }
    this.service = function () {
        return dec() ? that.member : null;
    };
    this.member = param;
    var secret = 3;
    var that = this;
}
var obj = new Container('abc');
console.log(obj.service());
console.log(obj.service());
console.log(obj.service());
console.log(obj.service());
console.log(obj.secret); //isto dá erro

//https://pt.stackoverflow.com/q/130931/101
