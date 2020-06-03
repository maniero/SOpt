preco_casa_raw = input("Qual o preço do imóvel?")
preco_casa = float(preco_casa_raw.replace('.', ''))
seu_salario = float(input("Qual o seu salário mensal?:"))
anos_a_pagar = float(input("Quantidade de anos a pagar pelo imóvel:"))
valor_prestacao = preco_casa / (anos_a_pagar * 12)
print (" O valor da prestação será de R$%.2f" % valor_prestacao)

#https://pt.stackoverflow.com/q/226603/101
