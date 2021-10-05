import csv

curso_desejado = input('Qual o curso? ')
vagas = 0
inscritos = 0
ingressos = 0
arquivo = open('oks4c.csv', encoding='utf8')
for registro in csv.reader(arquivo):
    if registro[0] == curso_desejado:
        vagas += int(registro[1])
        inscritos += int(registro[2])
        ingressos += int(registro[3])
print(f'O número de vagas oferecidas em {curso_desejado} é: {vagas}')
print(f'O número de inscritos em {curso_desejado} é: {inscritos}')
print(f'O número de ingressantes em {curso_desejado} é: {ingressos}')

#https://pt.stackoverflow.com/q/267801/101
