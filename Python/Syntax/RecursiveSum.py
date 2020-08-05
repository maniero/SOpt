def retorna(valor, limite, soma):
    if valor > limite:
        return soma
    return retorna(valor + 1, limite, soma + valor)
print(retorna(1, 5, 0))

#https://pt.stackoverflow.com/q/328197/101
