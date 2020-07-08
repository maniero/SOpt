a = {'0': 'Milhar', '1': 'Centena', '2': 'Dezena', '3': 'Unidade'}
while True:
    n = input('Digit a number: ') #só pede a digitação
    if n.isnumeric(): #verifica se é composto apenas por dígitos
        break #sai do laço se for
    else:
        print('Apenas numeros') #avisa o erro
r = len(n) #pega a quantidade de dígitos
if r >= 4: #normaliza para o máximo de 4
    r = 4
for c in range(0, r): #anda dígito por dígito
    print(f'{n[c]}: {a[str(r - c - 1)]}') #imprime a posição de cada caractere digitado
    #depois imprime o nome da grandeza pegando do dicionário, o - 1 porque começa do 0
    
#https://pt.stackoverflow.com/q/271952/101
