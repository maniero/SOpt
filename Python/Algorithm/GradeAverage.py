print('Sistema de nota escolar')
nome = input('Qual seu nome: ')
final = 0
for bimestre in range(1, 5):
    print(f'{bimestre}o. bimestre')
    nota1 = float(input('Primeira nota: '))
    nota2 = float(input('Segunda nota: '))
    nota3 = float(input('Terceira nota: '))
    nota4 = float(input('Quarta nota: '))
    media = (nota1 + nota2 + nota3 + nota4) / 4
    final += media
    print(f'Olá {nome} sua média no {bimestre}o. bimestre é {media}')
print(f'Olá {nome} sua média final é {final / 4} e você está {"aprovador" if final / 4 >= 5 else "reprovado"}')

#https://pt.stackoverflow.com/q/573063/101
