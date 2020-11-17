while True:
    numero = int(input('Digite um número inteiro e positivo: '))
    if numero >= 0:
        break
    print('O número não pode ser negativo.')
divisor = 1
soma = 0
for divisor in range(divisor, numero):
    if numero % divisor == 0:
    	soma += divisor
print(soma)

#https://pt.stackoverflow.com/q/482634/101
