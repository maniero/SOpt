Boolean x = true; //na verdade é traduzido para o abaixo
Boolean x = Boolean.valueOf(true);

ArrayList<Boolean> = lista = new ArrayList<>(); //válido
ArrayList<boolean> = lista = new ArrayList<>(); //inválido

void metodo(boolean x) {x = false;} //quando terminar o método, não muda nada no argumento
void metodo(Boolean x) {x = false;} //quando terminar o método, o argumento valerá false

//https://pt.stackoverflow.com/q/160914/101
