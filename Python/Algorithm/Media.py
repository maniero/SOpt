qntd_alunos = int(input("Digite a quantidade de alunos: "))
qnt = 0
media_geral = 0
while qnt <= qntd_alunos-1:
    MB1 = float(input("Digite a média do primeiro bimestre: "))
    MB2 = float(input("Digite a média do segundo bimestre: "))
    media_semestral = (MB1 + MB2) / 2
    media_geral += media_semestral
    if media_semestral >= 7:
        print("Você foi aprovado")
        print("Sua média semestral é: ", media_semestral)
    else:
        print("Sua média semestral é: ", media_semestral)
    qnt = qnt+1
    if qnt == 1:
        print(qnt, "aluno já recebeu sua média, faltam", qntd_alunos - qnt)

    else:
        print(qnt, "alunos já receberam suas médias, faltam", qntd_alunos - qnt)
print("Média geral ", media_geral / qntd_alunos)

#https://pt.stackoverflow.com/q/233809/101
