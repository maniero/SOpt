private static void copiarArquivos() throws IOException {
    File src = new File(".");
    String dstPath = "C:\\java\\";
    for (File f : src.listFiles()) {
        String fileName = f.getName();
        if (fileName.contains("File")) Files.move(f.toPath(), Paths.get(dstPath, fileName), REPLACE_EXISTING);
    }
}

//https://pt.stackoverflow.com/q/168715/101
