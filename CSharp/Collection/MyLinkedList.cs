using static System.Console;

public class Node<T> {
    public T Value { get; set; }
    public Node<T> Next { get; set; }
}

public class LinkedList<T> {
    private Node<T> head = null;

    public Node<T> Add(T value) {
        var node = new Node<T> {Value = value};
        if (head == null) head = node;
        else {
            var current = head;
            while (current.Next != null) current = current.Next;
            current.Next = node;
        }
        return node;
    }

    public T Remove(Node<T> node) {
        if (head == null) return node.Value;
        if (head == node) {
            head = head.Next;
            node.Next = null;
            return node.Value;
        }
        var current = head;
        while (current.Next != null) {
            if (current.Next == node) {
                current.Next = node.Next;
                return node.Value;
            }
            current = current.Next;
        }
        return node.Value;
    }

    public void Print() {
        var current = head;
        while (current != null) {
            WriteLine(current.Value);
            current = current.Next;
        }
    }
}

public class Program {
    public static void Main(string[] args) {
        var ll = new LinkedList<int>();
		var node1 = ll.Add(1);
        var node2 = ll.Add(2);
        var node3 = ll.Add(3);
        var node4 = ll.Add(4);
        var node5 = ll.Add(5);
        ll.Print();
		WriteLine();
        ll.Remove(node3);
        ll.Print();
    }
}

//https://pt.stackoverflow.com/q/164085/101
