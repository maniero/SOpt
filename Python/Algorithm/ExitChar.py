while True:
    entrada = input("Insira um número: ")
    if entrada == ' ':
        break
    try:
        num = int(entrada)
        print(num)
    except ValueError:
    	print('Dado inválido')

print('fim')

#https://pt.stackoverflow.com/q/462114/101
