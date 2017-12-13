from datetime import date

def verificacaoData():
  while True:
    dataForm = input('Digite a data atual no padrão dd/mm/aaaa: ')
    if date.today().strftime("%d/%m/%Y") != dataForm:
      print('Data informada difere da data atual.')
    else:
      print('Correto! Datas conferem!')
      break

verificacaoData()

#https://pt.stackoverflow.com/q/257108/101
