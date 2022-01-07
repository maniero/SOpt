x = 0
c = 0
while x < 4:
    login = input("Digite o login: ")
    senha = int(input("Digite a senha: "))
    x += 1
    if login == 'ifpe' and senha == 12345:
        break
    print("Login e/ou senha inválidos.")

print("  Código  | Produto          | Preço (R$)")
print("   100    | Cachorro-quente  |   1,70")
print("   101    | Bauru simples    |   2,30")
print("   102    | Bauru com ovo    |   2,60")
print("   103    | Hambúrguer       |   2,40")
print("    0     |   Sair")
print()
p = input("Digite o código do produto: ")
q = int(input("Digite a quantidade: "))
c += 1 
if p == 100:
    print("Valor: ", 2.30 + c)
    
#https://pt.stackoverflow.com/q/514497/101
