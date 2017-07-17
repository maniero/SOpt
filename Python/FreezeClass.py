import math
 
class Circulo():
    def __init__(self):
        super()
        self.__raio = None
 
    def get_perimetro(self):
        return 2 * math.pi * self.raio
 
    def get_area(self):
        return math.pi * self.raio ** 2
 
    @property
    def raio(self):
        return self.__raio
 
    @raio.setter
    def raio(self, x):
        self.__raio = x
 
    def __setattr__(self, key, value):
        if not hasattr(self, key):
            raise TypeError("Não pode criar atributos para esta classe")
        object.__setattr__(self, key, value)
 
c = Circulo()
c.raio = 2 # ok
c.lado = 2 # AttributeError

#https://pt.stackoverflow.com/q/220908/101
