printf("Quantos funcionarios deseja cadastrar? ");
scanf("%d", &qtdeFuncionarios);
Funcionario *funcionarios = malloc(qtdeFuncionarios * sizeof(Funcionario));

//https://pt.stackoverflow.com/q/410804/101
