def metodo(exec)
    exec.call "Vinicius"
end
codigo = proc do |nome|
    puts "Ola, #{nome}"
end
metodo(codigo)

#https://pt.stackoverflow.com/q/57924/101
