class A(object):
    def A():
        print('factory')
        return A()
    def __init__(self):
        print('init')
    def __call__(self):
        print('call')
print('chamar o construtor')
a = A()
print('chamar o construtor e a função')
b = A()()
print('chamar a função')
c = A.A()

#https://pt.stackoverflow.com/q/109813/101
