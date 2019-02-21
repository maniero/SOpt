String codPlPag = ListaBox.getSelectedItem().toString();
int posicaoBarra = codPlPag.indexOf(" /");
if(posicaoBarra != -1){
    int registro = stmt.executeUpdate("update pcpedc set codplpag ='" + 
                       codPlPag.substring(0, posicaoBarra) + "' where numped=" + consPCPEDC);
} else {
    //deu erro
}

String codPlPag = ListaBox.getSelectedItem().toString();
int registro = stmt.executeUpdate("update pcpedc set codplpag ='" + 
                       codPlPag.substring(0, 2) + "' where numped=" + consPCPEDC);
                       
//https://pt.stackoverflow.com/q/46246/101
