for (var i = 1; i <= lista.Count; i++) //erro aqui
for (var i = 1; i < lista.Count; i++) //certo

foreach (var item in lista) WriteLine(item); //assim não tem como dar esse erro

//https://pt.stackoverflow.com/q/411417/101
