public class teste {
    protected static int count = 0;
    public teste() {
        count++;
    }
    protected void finalize() throws Throwable {
        count--;
    } 
    public static int getInstanceCount() {
        return count;
    }
}

//https://pt.stackoverflow.com/q/96434/101
