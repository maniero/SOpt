import sys

contador = 1
maior = 0
menor = sys.maxsize
S = 0

while contador <= 5:
    num = int(input("Digite o " + str(contador) + "º valor:"))
    if num > maior:
        maior = num
    if num < menor:
        menor = num
    S += num
    contador += 1
print("A soma de todos os valore é igual a", S)
print("O maior valor digitado foi", maior)
print("O menor valor digitado foi", menor)

//http://pt.stackoverflow.com/a/177475/101
