function pulaLinha(repeticao) {
    for (let i = 0; i < repeticao; i++) document.write("<br>");
};

function mostra(frase) {
    document.write(frase);
    pulaLinha(2);
}

let ano = 2012; 
mostra("Eu nasci em : " + (ano - 25)); 
mostra("Adriano nasceu em : " + (ano - 26));
mostra("Paulo nasceu em : " + (ano - 32));
