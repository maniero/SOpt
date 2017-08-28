
function unique(value, index, self) { 
    return self.indexOf(value) === index;
}

var array = ['a', 'b', 'b', 'c', 'c'];
var unique = array.filter(unique);
console.log(unique);

//https://pt.stackoverflow.com/q/150413/101
