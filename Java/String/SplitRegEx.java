import java.io.*;

 class Test {
   public static void main(String args[]) {
      String line = new String("banana*batata.pepino#alface_tomate@cenoura abacate/morango\\laranja");
      for (String retval: line.split(" |#|@|_|\\\\|\\/|\\.|\\*") ){
         System.out.println(retval);
      }

   }
}

//https://pt.stackoverflow.com/q/41990/101
