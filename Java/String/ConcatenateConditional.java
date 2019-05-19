    void status(){
        System.out.println("O modelo do telefone é: " + getModelo());
        System.out.println("O telefone possui " + getNumeros() + " Numeros");
        System.out.println("A antela dele está pronta? " + getAntena());
        System.out.println("O telefone pode ligar? " + (this.antena ? "Estou ligando!" : "Não posso ligar!"));
    }
    
    //https://pt.stackoverflow.com/q/383855/101
