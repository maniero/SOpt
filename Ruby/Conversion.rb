nascimento = "12/34/5678"
dia =  nascimento[0,2].to_i
mes =  nascimento[3,2].to_i
ano =  nascimento[6,4].to_i
age = 2020 - 2000
if 8 <= mes && 14 < dia
    age -= 1 
end
puts dia
puts mes
puts ano
puts "Age #{age}"

#https://pt.stackoverflow.com/q/467893/101
