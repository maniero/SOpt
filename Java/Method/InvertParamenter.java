public static void copiaDestino(File origem, File destino) throws IOException{

    FileChannel inChannel = new FileInputStream(origem).getChannel();
    FileChannel outChannel = new FileOutputStream(destino).getChannel();
    try{
    int maxCont = (64 * 1024 * 1024) - (32 * 1024);
    long size = inChannel.size();
    long position = 0;

    while (position < size){
        position += inChannel.transferTo(position, size, outChannel);
    }
    }finally{
    if(inChannel != null){
        inChannel.close();
    }
    if(outChannel != null){
        outChannel.close();
    }
}

//No main():

try {
    File origem = new File("C:\\Novapasta\\server.sql");
    File destino = new File("C:\\t");
    copiaDestino(origem, destino)
} catch (Exception ex) { //isto só é útil aqui porque é o main
    System.out.println("Deu erro");
}

//https://pt.stackoverflow.com/q/82783/101
