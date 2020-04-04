def pegaDados(lista, ordinal):
    for n in range(1, 11):
        lista.append(int(input(f'Digite o {n}° elemento da {ordinal}° lista: ')))
    print('=' * 40)

n1 = list()
n2 = list()
n3 = list()
n4 = list()
pegaDados(n1, 1)
pegaDados(n2, 2)
pegaDados(n3, 3)

for n in range(0, 10):
    n4.append(n1[n])
    n4.append(n2[n])
    n4.append(n3[n])

print(f'Intercalando as listas 1, 2 e 3 temos:\n'
      f'{n4}')

#https://pt.stackoverflow.com/q/444536/101
