function passar(img) {
    passar.contador = passar.contador || 0;
    if (passar.contador == 0) {
        var confirma = confirm("Tem certeza que deseja aumentar a imagem?");
        if (confirma && passar.contador == 0) {
            passar.contador++;
            img.height *= 2;
            img.width *= 2;
       } else if (confirma && passar.contador == 1) {
            window.alert("Não é possível aumentar mais");
        }
    } else {
        var confirma = confirm("Tem certeza que deseja diminuir a imagem?");
        if (confirma && passar.contador == 1) {
            passar.contador--;
            img.height /= 2;
            img.width /= 2;
        } else if (confirma && passar.contador == 0) {
            window.alert("Não é possível diminuir mais");
        }
    }
}
var img = {height : 10, width : 10};
passar(img);
passar(img);

//https://pt.stackoverflow.com/q/117809/101
