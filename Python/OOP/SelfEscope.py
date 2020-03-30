class op():
    def __init__(self,num1,num2):
        self.x = num1
        self.y = num2

    def soma(self):
        return self.x + self.y

    def somadez(self):
        return self.soma() + 10

conta1 = op(1, 2)
print(conta1.soma())
print(conta1.somadez())

#https://pt.stackoverflow.com/q/442138/101
