n = int(input('Digite um número inteiro positivo: '))
soma = 0
conta = 0
num = 2
while conta < n:
    primo = True
    for i in range(2, num):
        if num % i == 0:
           primo = False
           break
    if primo:
        print(num)
        soma += num
        conta += 1
    num += 1
print(soma)

#https://pt.stackoverflow.com/q/454612/101
