function amanhaOuDepois(date: Date): boolean {
     return date.setHours(0, 0, 0, 0) > new Date().setHours(0, 0, 0, 0);
}
function ontemOuAntes(date: Date): boolean {
     return date.setHours(0, 0, 0, 0) < new Date().setHours(0, 0, 0, 0);
}
function hoje(date: Date): boolean {
     return date.setHours(0, 0, 0, 0) == new Date().setHours(0, 0, 0, 0);
}

//https://pt.stackoverflow.com/q/425049/101
