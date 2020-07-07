from random import choice

senha = ''.join([choice("abcdefghABCDEFGH") for i in range(16)])
print(senha)

#https://pt.stackoverflow.com/q/461052/101
