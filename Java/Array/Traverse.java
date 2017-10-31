try {
    ctx.get(FilialComplementoTO.FILIAL_COMPLEMENTO_KEY);
    //FilialComplementoTO filialComplementoTO = (FilialComplementoTO) ctx.get(FilialComplementoTO.FILIAL_COMPLEMENTO_KEY);
    LocalizarLojasCompositeEntity localizarLojasCompositeEntity = new LocalizarLojasCompositeEntity();
    estados = localizarLojasCompositeEntity.findEstadosBySgEstado();
    for(string estado : estados) {
        System.out.println(estado);
    }
    System.out.println("passou");
}

//https://pt.stackoverflow.com/q/37131/101
