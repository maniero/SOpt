ArrayList<File> arquivo = new ArrayList<File>();
ArrayList<FileInputStream> fis = new ArrayList<FileInputStream>();
ArrayList<DataInputStream> dis = new ArrayList<DataInputStream>();
for (int i = 0; i < 4; i++) {
    arquivo.add(new File("temp" + i.toString() + ".bin");
    fis.add(new FileInputStream(arquivo));
    dis.add(new DataInputStream(fis0));
}

//https://pt.stackoverflow.com/q/233653/101
