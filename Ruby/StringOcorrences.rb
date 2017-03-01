palavra = "palavra"
escolha = "a"
contagem = palavra.scan(/(?=#{escolha})/).count
puts "A palavra tem #{contagem} letras 'a' na palavra"

#http://pt.stackoverflow.com/q/187136/101
