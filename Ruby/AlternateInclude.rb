def includes(array, valor)
    for item in array
        if item == valor
           return true
        end
    end
    return false
end

chutes_ate_agora = ["a","b","c","d"]
novo_chute = gets.strip
teste = includes(chutes_ate_agora, novo_chute)
if teste then
   puts "já chutou letra #{novo_chute}"
else
   chutes_ate_agora << novo_chute
end
print chutes_ate_agora

#https://pt.stackoverflow.com/q/257960/101
