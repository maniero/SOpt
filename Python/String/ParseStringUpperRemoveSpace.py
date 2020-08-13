frase = input("Escreva uma frase: ")
fraseNova = ""
for chr in frase:
	if chr != " ":
	    fraseNova += chr.upper()
print(fraseNova)

#https://pt.stackoverflow.com/q/340130/101
