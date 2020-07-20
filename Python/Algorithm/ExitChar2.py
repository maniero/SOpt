frutas = []
add = 'sim'
while True:
    if add == 'sim':
        frutas.append(input('Qual fruta você quer adicionar à lista? '))
    add = input('Quer adicionar mais fruta? ')
    if add == 'não':
        break
    if add != 'sim' and add != 'não':
        add = print('Por favor digite sim ou não: ')
print(frutas)

#https://pt.stackoverflow.com/q/462840/101
