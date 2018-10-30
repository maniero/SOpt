local function contains(tabela, valor)
    for i = 1, #tabela do
        if tabela[i] == valor then 
            return true
        end
    end
    return false
end

local names = {"joão", "maria", "josé"}
if not contains(names, "carlos") then
    table.insert(names, "carlos")
end
for i = 1, #names do
    print(names[i])
end

--https://pt.stackoverflow.com/q/339407/101
