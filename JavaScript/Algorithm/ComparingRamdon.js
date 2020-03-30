function maquina(jogada) {
    var numero =  Math.floor(Math.random() * 3);
    if (numero == 0 && jogada == '1') {
        alert('maquina jogou pedra');
        alert('empate');
    }
    if (numero == 0 && jogada == '2') {
        alert('maquina jogou pedra');
        alert('voce ganhou');
    }
    if (numero == 0 && jogada == '3') {
        alert('maquina jogou pedra');
        alert('voce perdeu');
    }
    if (numero == 1 && jogada == '1') {
        alert('maquina jogou papel');
        alert('voce perdeu');
    }
    if (numero == 1 && jogada == '2') {
        alert('maquina jogou papel');
        alert('empate');
    }
    if (numero == 1 && jogada == '3') {
        alert('maquina jogou papel');
        alert('voce ganhou');
    }
    if (numero == 2 && jogada == '1') {
        alert('maquina jogou tesoura');
        alert('voce ganhou');
    }
    if (numero == 2 && jogada == '2') {
        alert('maquina jogou tesoura');
        alert('voce perdeu');
    }
    if (numero == 2 && jogada == '3') {
        alert('maquina jogou tesoura');
        alert('empate');
    }
}

alert('Bem vindo ao Pedra, Papel e Tesoura!')
if (prompt('Aperte 1 para comecar a jogar ') === '1') {
    alert('Escolha a sua jogada: ');
    var jgdJogador = prompt(`
                            1 - Pedra
                            2 - Papel
                            3 - Tesoura
                            `);
    if (jgdJogador === '1' || jgdJogador === '2' || jgdJogador === '3') maquina(jgdJogador);
}

//https://pt.stackoverflow.com/q/442048/101
