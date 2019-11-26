class A(object):
    def __init__(self):
        print("init")
    def __call__(self):
        print("call ")

a = A() #imprime init
A() #imprime call

#https://pt.stackoverflow.com/q/109813/101
