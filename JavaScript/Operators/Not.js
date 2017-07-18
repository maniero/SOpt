for (var i = 0; i < acentos.length; i++) {
    if (acentos[i] && acentos[i + 1] && acentos[i + 2]) {
        selSeat = i; //tenho medo desta variável solta
        //Codigo..
        if (confirm("Reserva da cadeira " + (i + 1) + " ~ " + (i + 3) + " está disponível, aceitar?.")) {
            break;
        } else {
            //Codigo..
        }
    }
}

//https://pt.stackoverflow.com/q/219732/101
