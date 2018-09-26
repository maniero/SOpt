import java.util.*;

class Program {
    public static void main(String[] args) {
        Scanner ent = new Scanner(System.in);
        System.out.println("Digite a palavra/frase:");
        // crio as strings
        String s = ent.nextLine();
        String r = ent.nextLine();
        // verifico se têm o mesmo tamanho
        if (isAnagram(s, r)) System.out.println("É anagrama");
    }
  
    public static boolean isAnagram(String s1, String s2) {
        //se as duas strings não tem o mesmo tamanho, não é anagrama
        if ( s1.length() != s2.length() ) return false;
        //tranfroma em arrays para poder ordenar
        char[] c1 = s1.toCharArray();
        char[] c2 = s2.toCharArray();
        //ordena para garantir a comparação simplificada
        Arrays.sort(c1);
        Arrays.sort(c2);
        //cria as novas strings baseadas nos arrays ordenados
        String sc1 = new String(c1);
        String sc2 = new String(c2);
        return sc1.equals(sc2);
    }
}

//https://pt.stackoverflow.com/q/42319/101
