class Classe(object):
    propriedade = 0
    def metodo(self):
        print(self.propriedade) #se tiver só propriedade aqui seria uma variavel local
        
objeto = Classe()
objeto.propriedade = 10
objeto.metodo()

#http://pt.stackoverflow.com/q/183675/101
