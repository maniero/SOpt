class Tela2(Screen):
    price = 0.0
    def op_dimoff(self):
        self.price = float((int(self.ngd) * 0.87 * 1.75) + self.price_inv)
        
#https://pt.stackoverflow.com/q/386288/101
