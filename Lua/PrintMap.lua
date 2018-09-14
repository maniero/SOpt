function table.map_length(t)
    local c = 0
    for k,v in pairs(t) do
         c = c+1
    end
    return c
end

a =  { move1 = "oi", move2 = "oi2"}

for x=1, table.map_length(a) do
    print(a["move" .. x])
end

for k, v in pairs(a) do
    print(v)
end

--https://pt.stackoverflow.com/q/38912/101
