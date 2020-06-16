num1 = int(input("Digite um número inteiro:"))
num2 = int(input("Digite outro número inteiro:"))
maior = num1 if num1 > num2 else num2
while maior % num1 != 0 or maior % num2 != 0:
    maior += 1
print(maior)

#https://pt.stackoverflow.com/q/237169/101
