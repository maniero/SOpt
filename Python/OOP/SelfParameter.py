class Pessoa:
    def __init__(self, nome, rg, cpf, telefone):
        self.nome = nome
        self.__rg = rg
        self.__cpf = cpf
        self.telefone = telefone
	
    def get_cpf(self):
        return self.__cpf
	
    def set_cpf(self, cpf):
        self.__cpf = cpf
        return self.__cpf
	
    def get_rg(self):
        return self.__rg
	
    def set_rg(self, rg):
        self.__rg = rg
        return self.__rg
	
    def exibir_dados(self):
        pass

class Medico(Pessoa):
    def __init__(self, nome, rg, cpf, telefone, crm, salario, especialidade):
        super().__init__(nome, rg, cpf, telefone)
        self.crm = crm
        self.salario = salario
        self.especialidade = especialidade
	
    def dados_medico(self):
        super().exibir_dados()
        print('Telefone: ', self.telefone)
        print('CRM: ', self.crm)
        print('Salário: ', self.salario)
        print('Especialidade: ', self.especialidade)

class Paciente(Pessoa):
    def __init__(self, nome, rg, cpf, telefone, endereco, nascimento):
        super().__init__(nome, rg, cpf, telefone)
        self.endereco = endereco
        self.nascimento = nascimento

medico_01 = Medico('Fulano de Tal', 12345647, 99933366645, 1199553644, '1111/SP', 2500.50, 'Ortopedista')
medico_01.dados_medico()

#https://pt.stackoverflow.com/q/480274/101
