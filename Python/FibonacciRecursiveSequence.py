def fibonacci(termo)
    return [] if termo == 0
    return [0] if termo == 1
    return [0, 1] if termo == 2 
    lista = fibonacci(termo - 1) 
    lista << lista[-2] + lista[-1]
    return lista
end
print fibonacci(10)

#https://pt.stackoverflow.com/q/336649/101
