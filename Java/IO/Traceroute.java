import java.net.InetAddress;

public class Ping {
    public static void main(String[] args) {
        try {
            if (args.length != 1) {
                System.out.println("Usage: java Ping <hostname>");
                System.exit(-1);
            }
            String host = args[0];
            int timeout = 3000;
            boolean status = InetAddress.getByName(host).isReachable(timeout);
            System.out.println(host + ": reachable? " + status);
        } catch (java.net.UnknownHostException e) {
            e.printStackTrace();
        } catch (java.io.IOException ioe) 
            ioe.printStackTrace();
        }
    }
}

//https://pt.stackoverflow.com/q/41668/101
