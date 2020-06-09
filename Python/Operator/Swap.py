def testes(x, y):
    while y:
        temp = x
        x = y
        y = temp % y
    return x
    
#https://pt.stackoverflow.com/q/456357/101
