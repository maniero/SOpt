def normaliza(texto):
    return texto[:7] + (("0" + texto[7]) if (not texto[8].isnumeric()) else (texto[7:9])) + texto[9:]

#https://pt.stackoverflow.com/q/384968/101
