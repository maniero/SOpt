import java.util.Map;

class Ideone {
    public static void main (String[] args) {
        Map<String, String> env = System.getenv();
        for (String envName : env.keySet()) System.out.format("%s=%s%n", envName, env.get(envName));
    }
}

//https://pt.stackoverflow.com/q/54512/101
