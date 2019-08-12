function shuffle(a) {
    let n = a.length;
    for (let i = 0; i < n; i++) {
        let swap = i + Math.floor(Math.random() * (n - i - 1));
        let aux = a[i];
        a[i] = a[swap];
        a[swap] = aux;
    }
}

let array = [5, 3, 1, 4, 2];
shuffle(array);
for (let i = 0; i < array.length; i++) console.log(array[i]);

//https://pt.stackoverflow.com/q/402427/101
