Conta = {balance = 0}
Contas = {}
Senhas = {}
Inicial = 5000
function Conta:withdraw (v)
    Conta.Balance = Conta.Balance - v
end

function Login()
    io.write("Digite seu Usuario\n")
    usuariol = io.read()
    io.write("Digite sua senha\n")
    senhal = io.read()

    for i=0, #Contas do
        for j=0, #Senhas do
            if usuariol == Contas[i] and senhal == Senhas[j] then
                io.write("Logado com sucesso!")
                Cadastro()
            end
        end
    end
end

function Cadastro()
    io.write("Ola, seja bem vindo ao sistema de Banco 1.0 By Charles \n")
    io.write("Deseja criar uma conta? \n")
    resposta = io.read()

    if resposta == "sim" or resposta == "Sim" then
        io.write("Ok, informe seu nome de usuario \n")
        usuario = io.read()
        io.write("Informe sua senha \n")
        senha = io.read()
        io.write("Aguarde um instante!\n")
        if #Contas == 0 and #Senhas == 0 then
            table.insert(Contas, 1, usuario)
            table.insert(Senhas, 1, senha)
        else
            table.insert(Contas, usuario)
            table.insert(Senhas, senha)
        end
        Login()

    elseif resposta == "tabela" then
        for i,v in ipairs(Contas) do
            print(v)
        end
        for i,v in ipairs(Senhas) do
            print(v)
        end
    end
end

Cadastro()

--https://pt.stackoverflow.com/q/48348/101
