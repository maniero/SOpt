const time1 = function () {
    console.log(gols)
    gols = 2
}

const time2 = function () {
    console.log(gols)
}

let gols = 1
gols = 3
time1() // 3
time2() // 2

//https://pt.stackoverflow.com/q/469227/101
