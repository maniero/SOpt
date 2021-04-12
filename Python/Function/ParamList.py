class Cheque:
    def __init__(self, **D):
       self.numConta = D.pop('nc', '------ -')
       self.numCheque = D.pop('nch', '?')
       self.valor = D.pop('v', '0.00')
       self.dta_emissao = D.pop('em', 'dd/mm/aaaa')
       self.dta_vcto = D.pop('vcto', 'dd/mm/aaaa')
       self.dta_deposito = D.pop('dep', 'dd/mm/aaaa')
       self.obs_verso = D.pop('obs', '?')

class Cliente:
    def __init__(self, listaCheque, **D):
        self.codigo   = D.pop('cod','--')
        self.nome     = D.pop('n','--')
        self.fone     = D.pop('fone','(--) ----- ----')
        self.data     = D.pop('dt','--/--/----')
        self.Endereco = D.pop('end','--')
        self.Cidade   = D.pop('cid','--')
        self.UF       = D.pop('uf','--')
        self.cheques  = []
        for x in listaCheque:
            self.cheques.append(x)
        self.tipo     = D.pop('tipo', '--')
    def listaCheque(self):
        return self.cheques
    def adicionaCheque(self, novoCheque):
        if novoCheque not in self.cheques:
            self.cheques.append(novoCheque)
    def excluiCheque(self, chequeAtual):
        if chequeAtual in self.cheques:
            self.cheques.remove(chequeAtual)

cheque1 = Cheque(nc = '123516-0', nch ='aaaa', v ='1' , em = '2', vcto ='3' , dep ='4' , obs ='5')
cheque2 = Cheque(nc = '123516-0', nch ='bbbb', v ='1' , em = '2', vcto ='3' , dep ='4' , obs ='5')
cheque3 = Cheque(nc = '123516-0', nch ='cccc', v ='1' , em = '2', vcto ='3' , dep ='4' , obs ='5')
cheque4 = Cheque(nc = '193516-0', nch ='dddd', v ='1' , em = '2', vcto ='3' , dep ='4' , obs ='5')
cheque5 = Cheque(nc = '163516-0', nch ='eeee', v ='1' , em = '2', vcto ='3' , dep ='4' , obs ='5')
cheque6 = Cheque(nc = '183516-0', nch ='ffff', v ='1' , em = '2', vcto ='3' , dep ='4' , obs ='5')

clientef1 = Cliente([cheque1,cheque3],cod = 44, n= 'Carlos', fone ='(41)9 93356-8903',\
                   dt ='08/03/2016', end = 'Rua X,123', cid ='Curitiba',\
                       uf = 'Pr', tipo = 'PF')

novoCheque = clientef1.adicionaCheque(cheque4)
for c in clientef1.listaCheque():    
    print(c.valor)
    
#https://pt.stackoverflow.com/q/504469/101
