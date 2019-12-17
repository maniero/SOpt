ActionListener trataEventos = new ActionListener() {
     public void actionPerformed(java.awt.event.ActionEvent e) {
         conteudo += e.getActionCommand();
         campoDoFormularioHTML.setMember("value", "" + conteudo);
     }
 }; 
 
 https://pt.stackoverflow.com/q/121163/101
