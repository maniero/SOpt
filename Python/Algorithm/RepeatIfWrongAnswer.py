import random

def c():
	numB = random.randint(0, 5)
	while True:
		num = int(input("Adivinha um numero de 0 a 5: ").strip())
		if num == numB:
		    print('Parabéns! Você acertou o numero\n'
		          'Você é um vencedor !')
		    break
		elif num > numB:
		    print("Valor errado")
		else:
		    print("Errado! Tente de Novo")
c()

#https://pt.stackoverflow.com/q/393462/101
