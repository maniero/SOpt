GET = {}
GET["positionX"] = "50,80,110"
tabela={}
i = 1
for palavra in string.gmatch(GET["positionX"], '([^,]+)') do
    tabela[i] = palavra
    i = i + 1
end
for k, v in pairs(tabela) do print(k, v) end

--https://pt.stackoverflow.com/q/54083/101
