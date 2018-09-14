a = {{a=1, b=2}, {a=2, b=3}, {a=1, b=2}, {a=3, b=2}, {a=1, b=2}}
 
for i = #a, 2, -1 do
	for j = i - 1, 1, -1 do
		if (a[j].a == a[i].a and a[j].b == a[i].b) then
			table.remove(a, i)
			break
		end
	end
end
 
-- demonstração do resultado:
for i, j in pairs(a) do
	print(i .. ". a=" .. j.a .. ", b=" .. j.b)
end

--https://pt.stackoverflow.com/q/38705/101
