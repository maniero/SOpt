function table.map_length(t)
    local c = 0
    for k,v in pairs(t) do
         c = c+1
    end
    return c
end
 
A = {
["b"] = {c=1, d=2},
["e"] = {f=1, g=2},
}
 
print(table.map_length(A))

--https://pt.stackoverflow.com/q/33301/101
