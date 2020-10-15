function includesTwo(array, one, two) {
    let achou = false;
    for (const item of array) {
        if (item == one || item == two) {
            if (achou) return true;
            achou = true;
        }
    }
    return false;
}

const a = ['view', 'edit', 'insert'];
console.log(includesTwo(a, 'view', 'edit'));
console.log(includesTwo(a, 'view', 'teste'));

//https://pt.stackoverflow.com/q/477551/101
