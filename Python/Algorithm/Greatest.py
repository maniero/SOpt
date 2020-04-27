maior = 0
quantos = 0
while True:
    valor = int(input())
    if valor < 1:
    	break
    if valor > maior:
        maior = valor
        quantos = 1
    elif valor == maior:
        quantos += 1
print('X =', maior, 'quantos = ', quantos)

#https://pt.stackoverflow.com/q/448608/101
