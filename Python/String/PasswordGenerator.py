from random import choice

minusculas = "abcdefgh"
maiusculas = "ABCDEFGH"
senha = []
pos = 0
while pos < 8:
    senha.append(choice(maiusculas))
    senha.append(choice(minusculas))
    pos += 1
print(''.join(senha))

#https://pt.stackoverflow.com/q/461052/101
