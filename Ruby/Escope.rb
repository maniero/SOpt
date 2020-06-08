x = 0
module Teste
  x = 0
  ::x = 1
end

puts x #gobal, vale 1
puts Teste::x #do módulo vale 0

#https://pt.stackoverflow.com/q/455807/101
