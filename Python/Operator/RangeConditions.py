n = int(input('De 0 a 10, qual a gravidade do crime?: '))
if n < 5: #se o numero for menor que 5
    print('Os policiais podem resolver')
elif n <= 8: #se o numero for menor ou igual a 8, já se sabe que não é menor que 5
    print('Os policiais precisam da ajuda do Batman!')
else: #já se sabe que o número não é menor ou igual a 8, então é maior
    print('O Batman resolve sozinho!')
    
#https://pt.stackoverflow.com/q/443323/101
