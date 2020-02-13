from random import randint

while True:
    pc = randint(0, 4)
    tent = int(input('PALPITE:'))
    if tent == pc:
    	break
    print('Você errou! o numero que o pc escoheu foi {}. Tente novamente '.format(pc))
print('Parabens!Você acertou! o Número que o o computador escolheu foi {}.'.format(pc))

#https://pt.stackoverflow.com/q/435391/101
