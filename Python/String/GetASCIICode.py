def DeslocaASCII(texto):
    novoTexto = ''
    for letra in texto:
        numero = ord(letra)
        novoTexto += chr(numero + (-23 if numero > 87 else 3))
    return novoTexto
    
print(DeslocaASCII('ABCDEFGHIJKLMNOPQRSTUVWXYZ'))

#https://pt.stackoverflow.com/q/253730/101
