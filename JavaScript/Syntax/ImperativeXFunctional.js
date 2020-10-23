function join(array) {
    var text = "";
    for (var i = 0; i < array.length; i++) {
        text += array[i];
    }
    return text;
}

function join(array, i, text) {
    var i = typeof(i) !== "undefined" ?  i : 0;
    var text = typeof(text) !== "undefined" ?  text : "";
    return (i == array.length) ? text : join(array, i + 1, text + array[i]);
}

function join([ head = '', ...tail ], text = '') {
    return tail.length === 0 ? (text + head) : join(tail, text + head);
}

Array.prototype.forEach = function(callback) {
    for (var i = 0; i < this.length; i++) {
        callback(this[i], i, this);
    }
}

//https://pt.stackoverflow.com/q/127121/101
