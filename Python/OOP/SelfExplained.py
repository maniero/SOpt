class Classe(object):
    propriedade = 0
    def metodo(self):
        print(self.propriedade) #se tiver só propriedade aqui seria uma variavel local
        
objeto = Classe()
objeto.propriedade = 10
objeto.metodo()

#https://pt.stackoverflow.com/q/176543/101
