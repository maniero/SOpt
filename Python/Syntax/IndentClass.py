from tkinter import *
class Janela:
    def __init__(self,toplevel):
        self.fr1 = Frame(toplevel)
        self.fr1.pack()

        self.botao1 = Button(self.fr1,text='Oi!')
        self.botao1['background']='green'
        self.botao1['font']=('Verdana','12','italic','bold')
        self.botao1['height']=3
        self.botao1.pack()

        self.botao2 = Button(self.fr1,bg='red', font=('Times','16'))
        self.botao2['text']='Tchau!'
        self.botao2['fg']='yellow'
        self.botao2['width']=12
        self.botao2.pack()

raiz=Tk()
Janela(raiz)
raiz.mainloop()

#https://pt.stackoverflow.com/q/346389/101
