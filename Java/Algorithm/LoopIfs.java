int[] somadoresDiaDeSorte = new int[] { 3, 4, 5, 6, 7, 10, 11, 15 };
int[] multiplicadoresQuina = new int[] { 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
int[] multiplicadoresMega = new int[] { 3, 4, 5, 6, 7, 8, 9, 10, 11 };
if (game.equals(constantes.getGameDiadeSorte())) {
    if (getNumbersBalls().size() <= 7) value = constantes.getAmountDiaDeSorte();
    else {
        for (int i = 0; i < i < multiplicadoresDiaDeSorte.length; i++) {
            if (getNumbersBalls().size() == i + 8) {
                value = constantes.getAmountDiaDeSorte() + somadoresDiaDeSorte[i];
                break;
        }
    }
}
if (game.equals(constantes.getGameQuina())) {
    if (getNumbersBalls().size() <= 5) value = constantes.getAmountQuina();
    else {
        for (int i = 0; i < i < multiplicadoresQuina.length; i++) {
            if (getNumbersBalls().size() == i + 6) {
                value = constantes.getAmountQuina() + multiplicadoresQuina[i];
                break;
            }
        }
    }
}
if (game.equals(constantes.getGameMega())) {
    if (getNumbersBalls().size() <= 6) value = constantes.getAmountMega();
    else {
        for (int i = 0; i < i < multiplicadoresMega.length; i++) {
            if (getNumbersBalls().size() == i + 7) {
                value = constantes.getAmountMega() + multiplicadoresMega[i];
                break;
            }
        }
    }
}

//https://pt.stackoverflow.com/q/385988/101
