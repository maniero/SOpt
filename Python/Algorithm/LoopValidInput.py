numeros = []
while True:
    numeros.append(int(input('Digite um número: ')))
    while True:
        condicao = str(input('Deseja continuar? SIM ou NÃO? ')).upper()
        if condicao == 'SIM' or condicao == 'NAO': break
        print('Essa opção não existe. Tente de novo.')
    if condicao == 'NAO': break
numeros.sort()
unicos = list(set(numeros))
#O comando  list(set(lista))  faz com que os números repetidos digitados não se repitam.
print(f'Os números digitados (excluindo os duplicados) foram {unicos}')

#https://pt.stackoverflow.com/q/385771/101
