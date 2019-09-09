void getGeneros(ArrayList biblioteca) {
    for (Genero genero : biblioteca.getLista()) {
        getArtistas(genero);
    }
}

void getArtistas(ArrayList genero) {
    for (Artista artistas : genero.getLista()) {
        getAlbuns(artistas);
    }
}

void getAlbuns(ArrayList artista) {
    for (Album album : artista.getLista()) {
        getMusicas(album);
    }
}

void getMusicas(ArrayList album) {
    for (Musica musica : album.getLista()) {
        GravaMusica(musica);
    }
}

//https://pt.stackoverflow.com/q/74064/101
