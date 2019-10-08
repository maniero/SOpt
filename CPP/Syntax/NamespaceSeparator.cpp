namespace exemplo {
    public class classe {
        static int membro = 0;
        int metodo(); //declarou o método dentro da classe
    }
}
int classe::metodo() { //definiu o método já declarado que pertence a "classe"
    return 0;
}

auto x = new exemplo::classe(); //instanciando "classe" que faz parte do "exemplo"
std::cout << x.metodo(); //estou chamando pela instância
std::cout << exemplo::classe::membro; //estou chamando um membro da classe

//https://pt.stackoverflow.com/q/87622/101
