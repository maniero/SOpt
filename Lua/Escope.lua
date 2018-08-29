local a = 2
local b = 6
local c = 4
local x1
do
   local a2 = 2 * a
   local d = math.sqrt(b ^ 2 - 4 * a * c)
   x1 = (-b + d) / a2
   x2 = (-b - d) / a2
end
print(x1, x2)

--https://pt.stackoverflow.com/q/325490/101
