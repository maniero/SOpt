//nome e local onde será gravado
String mPath = Environment.getExternalStorageDirectory().toString() + "/" + ACCUWX.IMAGE_APPEND;   

//cria a imagem
Bitmap bitmap;
View v1 = mCurrentUrlMask.getRootView();
v1.setDrawingCacheEnabled(true);
bitmap = Bitmap.createBitmap(v1.getDrawingCache());
v1.setDrawingCacheEnabled(false);

OutputStream fout = null;
imageFile = new File(mPath);

try {
    fout = new FileOutputStream(imageFile);
    bitmap.compress(Bitmap.CompressFormat.JPEG, 90, fout);
    fout.flush();
    fout.close();

} catch (FileNotFoundException e) {
    // TODO Auto-generated catch block
    e.printStackTrace();
} catch (IOException e) {
    // TODO Auto-generated catch block
    e.printStackTrace();
}

//Alternativa usando canvas conforme outra resposta no SO:

public Bitmap screenShot(View view) {
    Bitmap bitmap = Bitmap.createBitmap(view.getWidth(), view.getHeight(), Config.ARGB_8888);
    Canvas canvas = new Canvas(bitmap);
    view.draw(canvas);
    return bitmap;
}

//https://pt.stackoverflow.com/q/55260/101
