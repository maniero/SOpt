idade = int(input('Quantos anos você tem?'))
print('\n')
if idade < 1:
     print('Não sei o que fazer com este valor.')
elif 0 < idade < 10:
   print('Você é uma criança.')
elif idade < 20:
     print('Você é um jovem.')
elif idade < 40:
     print('Você é um adulto.')
elif idade < 60:
    print('Você está na meia-idade.')
else:
     print('Você está na velhice.')
     
#https://pt.stackoverflow.com/q/391288/101
