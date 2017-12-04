while True:
    name = input('Digite seu nome de usuário:')
    if not name.isalpha():
        print('Apenas letras são permitidas na nomeação do usuário.')
    else:
        break
while True:
    password = input('Digite sua nova senha:')
    if password == name:
        print('\n\nSua senha não pode ser igual ao seu nome de usuário.\n')
    elif len(password) < 8 or len(password) > 16:
        print('\n\nSua senha deve ter no mínimo 8 e no máximo 16 caracteres.\n')
    elif not (any(char.isdigit() for char in password) and any(char.isalpha() for char in password)):
        print('\n\nSua senha deve conter letras e números.\n')
    else:
        break
while True:
    password2 = input('Digite sua nova senha:')
    if password2 != password:
        print('Suas senhas não coincidem, tente novamente.')
    else:
        break
print('Usuário registrado com sucesso.')

#https://pt.stackoverflow.com/q/260407/101
