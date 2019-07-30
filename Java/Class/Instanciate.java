package newpackage;

import java.util.ArrayList;
import javax.swing.JOptionPane;

public class Operacoes {
    ArrayList<Cliente> clientes;

    public Operacoes() {
        cliente = new ArrayList<Cliente>(); //note que mudei os nomes para ficar menos confuso
    }

    public void cadastroCliente() {
        Cliente cliente = new Cliente();
        int aux = clientes.size() + 1; //pega a quantidade de elementos atual e incrementa
        cliente.setCodigo(aux);
        cliente.setNome(JOptionPane.showInputDialog((aux)
                + "º Cliente\nNome: "));
        cliente.setEmail(JOptionPane.showInputDialog("E-mail: "));

        clientes.add(cliente);
    }
}

//https://pt.stackoverflow.com/q/51604/101
