from random import randint

pc = randint(0, 4)
contador = 0
while True:
    contador += 1
    tent = int(input('PALPITE:'))
    if tent == pc:
        break
    print('Você errou! Tente novamente '.format(pc))
print('Parabens!Você acertou! o Número que o computador escolheu foi {} em {} tentativas.'.format(pc, contador))

#https://pt.stackoverflow.com/q/435391/101
