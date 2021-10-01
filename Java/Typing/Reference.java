void exemplo(int x) { x = 1; } //quem chamar este método não terá seu valor mudado para 1
void exemplo(Integer x) { x = 1; } //quem chamar este método terá seu valor mudado para 1
void exemplo(String x) { x = "x"; } //quem chamar não terá seu valor mudado para "x"
void exemplo(MinhaClasse x) { x.setNome("João"); } //o campo nome será mudado

//https://pt.stackoverflow.com/q/150899/101
