tabela = {
    {pessoa = "Joao", idade = 20},
    {pessoa = "Pedro", idade = 22},
    {pessoa = "Lucas", idade = 19},
    {pessoa = "Derp", idade = 25}
}
table.sort(tabela, function(value1, value2) return value1.idade > value2.idade end)
for x = 1, table.maxn(tabela) do
    print(tabela[x].idade)
end

--https://pt.stackoverflow.com/q/35208/101
