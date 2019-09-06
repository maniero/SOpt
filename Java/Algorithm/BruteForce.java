import java.util.Arrays;

public class BruteForce {

  final int min;
  final int max;
  final int stringLength;

  /**
   * One more element than <i>stringLength</i>,
   * to efficiently check for overflow.
   */
  private final int[] chars;

  public BruteForce(char min, char max, int len) {
    this.min = min;
    this.max = max;
    this.stringLength = len;

    chars = new int[stringLength + 1];
    Arrays.fill(chars, 1, chars.length, min);
  }

  public void run() {
    while (chars[0] == 0) {
      print();
      increment();
    }
  }

  private void increment() {
    for (int i = chars.length - 1; i >= 0; i--) {
      if (chars[i] < max) {
        chars[i]++;
        return;
      }
      chars[i] = min;
    }
  }

  private void print() {
    for (int i = 1; i < chars.length; i++) {
      System.out.print((char) chars[i]);
    }
    System.out.println();
  }

  public static void main(String[] args) {
    new BruteForce('a', 'z', 4).run();
  }

}

//https://pt.stackoverflow.com/q/73271/101
