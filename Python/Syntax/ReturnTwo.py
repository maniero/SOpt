def soma(a, b):
    x = a + b
    y = 'qualquer coisa'
    if x > 5:
        return x
    else:
        return y

def soma(a, b):
    x = a + b
    y = 'qualquer coisa'
    yield x
    yield y

def soma(a, b):
    x = a + b
    y = 'qualquer coisa'
    return (x, y)
    
#https://pt.stackoverflow.com/q/331155/101
