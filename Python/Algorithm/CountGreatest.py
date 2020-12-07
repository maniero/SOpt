num_lidos = int(input('Digite a quantidade de números: '))
maior = 0
qnt = 0
for num in range(0, num_lidos):
    num = int(input('Digite o valor: '))
    if num > maior:
        maior = num
        qnt = 1
    elif num == maior:
        qnt += 1
print(f'Maior valor = {maior}')
print(f'Quantidade de vezes que o maior número foi lido: {qnt}')

#https://pt.stackoverflow.com/q/485318/101
