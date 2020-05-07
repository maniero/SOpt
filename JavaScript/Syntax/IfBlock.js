if (false)
    console.log(1);
    console.log(2);

if (false) {
    console.log(1);
    console.log(2);
}

if (false)
    if (true)
        console.log(1);
else
    console.log(2);

if (false) {
    if (true) {
        console.log(1);
    } else {
        console.log(2);
    }
}

if (false)
    if (true)
        console.log(1);
    else
        console.log(2);

let x = 1;
{
   let x = 2;
   console.log(x);
}
console.log(x);

//https://pt.stackoverflow.com/q/450094/101
