import random

ConvInicial = str(input('Você: '))
if ConvInicial == 'Não estou passando bem' or ConvInicial == 'Estou com dor' or ConvInicial == 'Preciso de ajuda':
    while True:
        print('O que você está sentindo?')
        RespDor = input('Você: ')
        if RespDor == 'Estou com dor de cabeça' or RespDor == 'Dor de cabeça' or RespDor == 'Minha cabeça dói':
            print('Você pode usar um {} para aliviar sua dor!'.format(random.choice(['Neosaldina', 'Dorflex', 'Advil', 'Tylenol', 'Aspirina', 'Naldecon'])))
            break; #para encerrar o laço de repetição
        else:
            print('Não entendi, poderia ser mais claro?')
            
#https://pt.stackoverflow.com/q/336185/101
