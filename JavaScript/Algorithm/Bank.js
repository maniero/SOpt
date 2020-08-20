var opcao, vl_saq;
var saldo = 0;
var min = 0;
var max = 2000;
do {
    opcao = parseInt(prompt("Escolha uma opção:\n1 - Saque\n2 - Depósito\n3 - Saldo\n0 - Sair")); // MENU inicial
    switch (opcao) {
    case 1:
        vl_saq = parseInt(prompt("Digite o valor do saque:"));
        if (vl_saq > saldo) {
            if (vl_saq > 0 && vl_saq < max) {
                alert("O saque está sendo realizado...\nAperte em OK");
                saldo -= vl_saq;
                alert("Operação Realizada!");
            } else alert("Só podem entrar no saque, valores que sejam entre R$0,00 e R$2.000,00");
        } else alert("Saldo insuficiente! Você pode sacar\nR$ "+saldo.toFixed(2));
        break;
    }
} while (opcao != 0);

//https://pt.stackoverflow.com/q/351357/101
