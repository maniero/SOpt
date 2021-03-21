n1 = float(input('Dígite sua primeira nota:'))
n2 = float(input('Dígite sua segunda nota:'))
if n1 > 10.0 or n2 > 10.0 or n1 < 0.0 and n2 < 0.0:
    print('Nota inválida')
else:
    print(f'Sua média é {(n1  +n2) / 2}')
    
#https://pt.stackoverflow.com/q/498501/101
