function formatar_valor(strvalor) {
    return strvalor.substring(0, 4) + "." + strvalor.substring(4, 8) + "." + 
             strvalor.substring(8, 12) + "-" + strvalor.substring(12, 13);
}
console.log(formatar_valor('1234213412341'));

//https://pt.stackoverflow.com/q/55085/101
