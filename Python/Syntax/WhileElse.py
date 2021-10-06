vetor = []
for i in range(0, 5): vetor.append(int(input('Digite um valor: ')))
num = int(input("Digite o valor a ser pesquisado: "))
i = 0
while i < 5:
    if num == vetor[i]: 
    	print("O numero {0} esta na posição {1}".format(num, i + 1))
    	break
    i += 1
else:
    print("O numero {0} não se encontra na lista".format(num))
    
#https://pt.stackoverflow.com/q/386772/101
