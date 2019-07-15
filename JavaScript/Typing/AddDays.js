let meses = ["janeiro", "fevereiro", "março", "abril", "maio", "junho", "julho", "agosto", "setembro", "outubro", "novembro", "dezembro"];
let data = new Date();
data.setDate(data.getDate() + 5);
document.write("Válido até dia " + data.getDate() + " de " + meses[data.getMonth()] + ", corra e garanta sua vaga!<br>");
data = new Date(2019, 6, 30);
data.setDate(data.getDate() + 5);
document.write("Válido até dia " + data.getDate() + " de " + meses[data.getMonth()] + ", corra e garanta sua vaga!");

//https://pt.stackoverflow.com/q/397189/101
