local acum = 1
local n1 = 6
for i = 1, 9, 1 do
    if n1 % 2 == 0 then
    	acum = acum * 2
    	n1 = n1 / 2
    elseif n1 % 3 == 0 then
    	acum = acum * 3
    	n1 = n1 / 3
    elseif n1 % 5 == 0 then
    	acum = acum * 5
    	n1 = n1 / 5
    elseif n1 % 7 == 0 then
    	acum = acum * 7
    	n1 = n1 / 7 
    end
    if n1 == 1 then break end
end
print(acum)

--https://pt.stackoverflow.com/q/169534/101
