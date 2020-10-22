glossario = {
    'concatenar': 'Concatenar é a junção de 2 cadeias de caracteres'
        ' e que dá origem a uma nova string' \
        ' que é formada pela junça das 2 partes.',
        'identar': 'Indentar é o recuo do texto em relação a sua margem',
    'array': 'Arrays são estruturas de dados' \
            ' semelhantes às listas do Python',
    'string': 'String é um objeto iterável.',
    }
for palavra, significado in set(glossario.items()):
    print(palavra.title() + ":" + "\n" + significado + '\n')
    
glossario['sequência'] = 'Sequências são coleções ordenadas embutidas:' \
    'strings, listas, tuplas e buffers.'
    
#https://pt.stackoverflow.com/q/478557/101
