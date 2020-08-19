while True:
    registros = raw_input()
    if registros[0] == '-':
        break
    i = 0
    faltas = 0
    while i < len(registros):
        if registros[i] == 'f':
            faltas += 1
        i += 1
    print faltas

#https://pt.stackoverflow.com/q/349204/101
