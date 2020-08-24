vogais = 'aeiou'
palavra = input('Digite uma palavra: ')
for letra in palavra:
    if letra in vogais:
    	print(letra.upper())
    else:
    	print(letra)

#https://pt.stackoverflow.com/q/356136/101
