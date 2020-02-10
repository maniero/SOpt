lista = []
while True:
    i = int(input('Digite um número: '))
    if i < 1: break
    lista.append(i)
for i in lista[::-1]:
    print(i)
for i in reversed(lista):
    print(i)

#https://pt.stackoverflow.com/q/435043/101
