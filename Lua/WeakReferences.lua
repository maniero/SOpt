a = {}
b = {}
setmetatable(a, b)
b.__mode = "v"
tabela = {}
a[1] = tabela
tabela = {}
a[2] = tabela
collectgarbage()
for k, v in pairs(a) do print(v) end

//http://pt.stackoverflow.com/a/177673/101
