def somadig(n):
    if n == 0:
        return 0
    else:
        return (n % 10) + somadig(n // 10)

print(somadig(120))

#https://pt.stackoverflow.com/q/349093/101
