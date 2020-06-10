listaidademenorde18 = []
listaidademaiorde18 = []
while True:
    try:
        idade = int(input('Digite a idade da pessoa: '))
        break
    except ValueError:
    	pass
if idade < 18:
    listaidademenorde18.append(idade)
else:
    listaidademaiorde18.append(idade)
print(listaidademenorde18)
print(listaidademaiorde18)

#https://pt.stackoverflow.com/q/456654/101
