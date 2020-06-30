while True:
    sex = input('Digite seu sexo:')
    if sex == 'M' or sex == 'F':
        break
Quer continuar fazendo daquela forma?

sex = input('Digite seu sexo:')
while sex != 'M' and sex != 'F':
    sex = input('Digite seu sexo:')
    
#https://pt.stackoverflow.com/q/257156/101
