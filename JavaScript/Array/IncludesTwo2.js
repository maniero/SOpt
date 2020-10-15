function includesTwo(array, one, two) {
    let achouOne = false;
    let achouTwo = false;
    for (const item of array) {
        if (item == one) {
            if (achouTwo) return true;
            achouOne = true;
        }
        if (item == two) {
            if (achouOne) return true;
            achouTwo = true;
        }
    }
    return false;
}

const a = ['view', 'view', 'edit'];
console.log(includesTwo(a, 'view', 'edit'));
console.log(includesTwo(a, 'view', 'teste'));

//https://pt.stackoverflow.com/q/477551/101
