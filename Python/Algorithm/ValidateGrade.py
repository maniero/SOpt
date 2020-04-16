import sys

n1 = int(input('digite nota 1: '))
n2 = int(input('digite nota 2: '))
if n1 > 10:
    print('{} não é uma nota válida!'.format(n1))
    sys.exit(0)
if n2 > 10:
    print('{} não é uma nota válida!'.format(n2))
    sys.exit(0)
media = (n1 + n2) / 2
if media >= 7:
    print('Você foi aprovado com média {}'.format(media))
else:
    print('Você foi reprovado com média {}'.format(media))
    
#https://pt.stackoverflow.com/q/446515/101
