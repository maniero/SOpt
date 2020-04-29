function pulaLinha() {
    document.write("<br>");
};

function mostra(frase) {
    document.write(frase);
    for (let i = 0; i < 5; i++) pulaLinha();
}

let ano = 2012; 
mostra("Eu nasci em : " + (ano - 25)); 
mostra("Adriano nasceu em : " + (ano - 26));
mostra("Paulo nasceu em : " + (ano - 32));
