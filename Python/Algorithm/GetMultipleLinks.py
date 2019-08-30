c = input("Quantos links de download deseja colocar: ")
print()
i = 0
texto = ""
while (i < int(c)):
    dw = input("Link de Download:")
    texto = texto + dw + "  "
    i = i + 1
    print()
print(texto)

#https://pt.stackoverflow.com/q/57071/101
