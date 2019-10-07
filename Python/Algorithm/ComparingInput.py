print("Insira dois valores para serem comparados:")
valor1 = float(input("\nEscreva um número:"))
valor2 = float(input("\nEscreva outro número:"))
print("\nConfirme os números que você inseriu digitando 'sim':\n", valor1, "\n", valor2)
if input() == "sim":
    if valor1 > valor2:
        print("O primeiro valor é maior que o segundo")
    elif valor2 > valor1:
        print("O segundo valor é maior que o primeiro")
    elif valor2 == valor1:
        print("Os números são iguais")
else:
    print("Então insira os números corretos")
    
#https://pt.stackoverflow.com/q/414484/101
