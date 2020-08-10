matricula = int(input("Digite a matrícula do Aluno: "))
nota1  = float(input("Digite a primeira nota do aluno: "))
nota2  = float(input("Digite a primeira nota do aluno: "))
nota3  = float (input("Digite a primeira nota do aluno: "))
media = (nota1 +  (nota2 * 2) + (nota3 * 3)) / 6
if media > 6:
    print(" O Aluno  de matricula ", matricula, " Foi APROVADO com a média: ", media)
else:
    print(" O Aluno  de matricula ", matricula, " Foi REPROVADO com a média: ", media)
    
#https://pt.stackoverflow.com/q/336030/101
