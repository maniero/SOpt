p1 = int(input("Digite o 1° preço: "))
p2 = int(input("Digite o 2° preço: "))
p3 = int(input("Digite o 3° preço: "))
if p1 < p2 and p1 < p3:
    print(f'O produto mais barato é o {p1}')
elif p2 < p1 and p2 < p3:
    print(f'O produto mais barato é o {p2}')
elif p3 < p2 and p3 < p1:
    print(f'O produto mais barato é o {p3}')

#https://pt.stackoverflow.com/q/353792/101
