idade = int(input('Qual sua idade? '))
preço = float(input('Informe o valor: '))
desconto = 7.0
if preço >= 23 and preço <= idade:
    print('Você terá um desconto de: R${:.2f}'.format(desconto))
else:
    print('sem desconto')
    
#https://pt.stackoverflow.com/q/446362/101
