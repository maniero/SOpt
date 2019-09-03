def metodo(exec)
    exec.call "Vinicius"
end
idade = 20
codigo = proc do |nome|
    puts "Ola, #{nome}, voce tem #{idade} anos"
end
metodo(codigo)

#https://pt.stackoverflow.com/q/57924/101
