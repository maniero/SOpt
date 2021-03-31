def funcao():
    return 1
variavel = funcao() + 2
print variavel

variavel = 1 + 2
print variavel

def f(var):
    print(var)
def funcao():
    return f
variavel = funcao()
variavel('OI')

def f(var):
    print(var)
variavel = f
variavel('OI')

def f(var):
    print(var)
variavel = f('OI')

#https://pt.stackoverflow.com/q/497714/101
