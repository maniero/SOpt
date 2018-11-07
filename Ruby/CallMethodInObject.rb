class Soma
    def somar(num1, num2)
        @num1 = num1
        @num2 = num2
        result = num1 + num2
        puts "O resultado é #{result}"
    end
end

somando = Soma.new()
somando.somar(1, 2)

#https://pt.stackoverflow.com/q/341542/101
