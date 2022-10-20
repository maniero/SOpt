interface Adder {
    int add(int a, int b);
}
class AdderImpl implements Adder {
    public int add(int a, int b) {
        return a + b;
    }
}

import static org.junit.Assert.assertEquals;

import org.junit.Test;

public class TestAdder {

    @Test
    public void testSumPositiveNumbersOneAndOne() {
        Adder adder = new AdderImpl();
        assertEquals(2, adder.add(1, 1));
    }

    // can it add the positive numbers 1 and 2?
    @Test
    public void testSumPositiveNumbersOneAndTwo() {
        Adder adder = new AdderImpl();
        assertEquals(3, adder.add(1, 2));
    }

    // can it add the positive numbers 2 and 2?
    @Test
    public void testSumPositiveNumbersTwoAndTwo() {
        Adder adder = new AdderImpl();
        assertEquals(4, adder.add(2, 2));
    }

    // is zero neutral?
    @Test
    public void testSumZeroNeutral() {
        Adder adder = new AdderImpl();
        assertEquals(0, adder.add(0, 0));
    }

    // can it add the negative numbers -1 and -2?
    @Test
    public void testSumNegativeNumbers() {
        Adder adder = new AdderImpl();
        assertEquals(-3, adder.add(-1, -2));
    }

    // can it add a positive and a negative?
    @Test
    public void testSumPositiveAndNegative() {
        Adder adder = new AdderImpl();
        assertEquals(0, adder.add(-1, 1));
    }

    // how about larger numbers?
    @Test
    public void testSumLargeNumbers() {
        Adder adder = new AdderImpl();
        assertEquals(2222, adder.add(1234, 988));
    }
}

//https://pt.stackoverflow.com/q/115146/101
