def media(*lista):
    soma = 0
    for i in lista:
        soma += i
    return soma // len(lista)
lista = [7, 8, 9]
print(media(*lista))

#https://pt.stackoverflow.com/q/361203/101
