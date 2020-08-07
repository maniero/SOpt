import math

is_magic = []
for n in range(8, 27):
    valor = pow(n, 0.5)
    if valor == 2 or valor == 3 or valor == 5 or valor == 7:
        is_magic.append(n)
print(is_magic)

#https://pt.stackoverflow.com/q/466768/101
