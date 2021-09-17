module Teste
  def minha_funcao
    puts 'função'
  end
end
puts Teste.method_defined?(:minha_funcao)
#puts Teste.method_defined?(minha_funcao)

#https://pt.stackoverflow.com/q/527833/101
