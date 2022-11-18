a = int(input('digite um número:'))
b = int(input('digite outro número:'))
c = (input("escolha a operação que deseja: / para dividir, * para multiplicar - para subtrair e + para somar: "))
while c != "/" and c != "*" and c != "-" and c != "+":
    c = (input("digite um operador válido"))
if c == "/":
    print (a / b)
elif c == "*":
    print(a * b)
elif c == "-":
    print(a - b)
else:
    print(a + b)
    
#https://pt.stackoverflow.com/q/570637/101
