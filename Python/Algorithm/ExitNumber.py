print('Digite 0 para terminar o cadastro!')
cont = 1
lista = []
while True:
    n = input('Funcionário {}: '.format(cont))
    if n == "0":
        break
    lista.append(n)
    cont += 1
print(lista)

#https://pt.stackoverflow.com/q/446743/101
