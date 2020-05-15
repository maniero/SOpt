lista = [1, 2, 3]
try:
    numero = int(input(f'Digite um número entre 0 e {len(lista)-1}: '))
    print(lista[numero])
except ValueError:
	print('Não foi digitado um número')
except IndexError:
    print('O número digitado está fora da faixa aceita')
    
#https://pt.stackoverflow.com/q/451936/101
