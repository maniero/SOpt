a = float(input('Nota 1: '))
b = float(input('Nota 2: '))
c = float(input('nota 3: '))
d = float(input('nota 4: '))
m1 = (a + b + c + d) / 4
if m1 >= 7:
    print('Aprovado media %f' % m1)
else:
    e = float(input('nota exame: '))
    m2 = (m1 + e) / 2
    if m2 >= 5:
        print('Aluno aprovado media %f' % m2)
    else:
        print('Reprovado media %f' % m2)

#https://pt.stackoverflow.com/q/393097/101
