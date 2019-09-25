local table_2 = {
   ["tabela1"] = { "360Mhz", "demo", "teste" },
   ["tabela2"] = { "360Mhz", "demo", "teste" }
}
for k, v in pairs(table_2) do
   print(k)
   for k2, v2 in pairs(v) do
      print("   ", v2)
   end
end

--https://pt.stackoverflow.com/q/81558/101
