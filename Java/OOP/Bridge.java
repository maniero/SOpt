class Node {
    public int value;
    public Node prev, next;

    public Node(int i) {
        value = i;
    }
}

class Stack {
    private StackImpl impl;

    public Stack( String s ) {
        if (s.equals("array")) {
            impl = new StackArray();
        } else if (s.equals("list")) {
            impl = new StackList();
        } else {
            System.out.println("Stack: unknown parameter");
        }
    }

    public Stack() {
        this("array");
    }

    public void push(int in) {
        impl.push( in );
    }

    public int pop() {
        return impl.pop();
    }

    public int top() {
        return impl.top();
    }

    public boolean isEmpty() {
        return impl.isEmpty();
    }

    public boolean isFull() {
        return impl.isFull();
    }
}

class StackHanoi extends Stack {
    private int totalRejected = 0;

    public StackHanoi() {
        super("array");
    }

    public StackHanoi(String s) {
        super(s);
    }

    public int reportRejected() {
        return totalRejected;
    }

    public void push(int in) {
        if (!isEmpty() && in > top()) {
            totalRejected++;
        }
        else {
            super.push(in);
        }
    }
}

class StackFIFO extends Stack {
    private StackImpl stackImpl = new StackList();

    public StackFIFO() {
        super("array");
    }

    public StackFIFO(String s) {
        super(s);
    }

    public int pop() {
        while (!isEmpty()) {
            stackImpl.push(super.pop());
        }
        int ret = stackImpl.pop();
        while (!stackImpl.isEmpty()) {
            push(stackImpl.pop());
        }
        return ret;
    }
}

interface StackImpl {
    void push(int i);
    int pop();
    int top();
    boolean isEmpty();
    boolean isFull();
}

class StackArray implements StackImpl {
    private int[] items;
    private int total = -1;

    public StackArray() {
        this.items = new int[12];
    }

    public StackArray(int cells) {
        this.items = new int[cells];
    }

    public void push(int i) {
        if (!isFull()) {
            items[++total] = i;
        }
    }

    public boolean isEmpty() {
        return total == -1;
    }

    public boolean isFull() {
        return total == items.length - 1;
    }

    public int top() {
        if (isEmpty()) {
            return -1;
        }
        return items[total];
    }

    public int pop() {
        if (isEmpty()) {
            return -1;
        }
        return items[total--];
    }
}

class StackList implements StackImpl {
    private Node last;

    public void push(int i) {
        if (last == null) {
            last = new Node(i);
        } else {
            last.next = new Node(i);
            last.next.prev = last;
            last = last.next;
        }
    }

    public boolean isEmpty() {
        return last == null;
    }

    public boolean isFull() {
        return false;
    }

    public int top() {
        if (isEmpty()) {
            return -1;
        }
        return last.value;
    }

    public int pop() {
        if (isEmpty()) {
            return -1;
        }
        int ret = last.value;
        last = last.prev;
        return ret;
    }
}

public class BridgeDisk {
    public static void main(String[] args) {
        Stack[] stacks = {new Stack("array"), new Stack("list"),
                new StackFIFO(), new StackHanoi()};
        for (int i=1, num; i < 15; i++) {
            for (int j=0; j < 3; j++) {
                stacks[j].push( i );
            }
        }
        Random rn = new Random();
        for (int i=1, num; i < 15; i++) {
            stacks[3].push(rn.nextInt(20));
        }
        for (int i=0, num; i < stacks.length; i++) {
            while (!stacks[i].isEmpty()) {
                System.out.print(stacks[i].pop() + "  ");
            }
            System.out.println();
        }
        System.out.println("total rejected is " + ((StackHanoi)stacks[3]).reportRejected());
    }
}

//https://pt.stackoverflow.com/q/284910/101
