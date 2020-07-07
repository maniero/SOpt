def main():
    ocorrencia = 0
    numeroReal = int(input("Digite um número inteiro positivo:\n"))
    numero = numeroReal
    digito = int(input("Digite um dígito para que analisemos sua ocorrência no número anteriormente digitado:\n"))
    while numero != 0:
        if (numero % 10 == digito):
            ocorrencia += 1
        numero = numero // 10
    print("O dígito ", digito, "ocorre", ocorrencia, "vezes no número", numeroReal)
main()

#https://pt.stackoverflow.com/q/461085/101
