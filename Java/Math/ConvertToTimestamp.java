String tempo = Métodos.getStringTempo();
int tempoSemLetra = Integer.valueOf(tempo.replace("s", "").replace("m", "")
                                         .replace("h", "").replace("d", ""));
long added = 0L; //não sei porque precisa de long
if (tempo.endsWith("s")) {
   added = tempoSemLetra * 1000; 
} else if (tempo.endsWith("m")) {
   added = tempoSemLetra * 60 * 1000; 
} else if (tempo.endsWith("m")) {
   added = tempoSemLetra * 60 * 60 * 1000; 
else if (tempo.endsWith("d")) { 
   added = tempoSemLetra * 24 * 60 * 60 * 1000; 
}
Timestamp timestamp = new Timestamp(System.currentTimeMillis() + added);

//https://pt.stackoverflow.com/q/170813/101
