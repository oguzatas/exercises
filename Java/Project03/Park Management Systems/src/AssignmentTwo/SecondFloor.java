package AssignmentTwo;


import java.util.LinkedList;
import java.util.List;
import java.util.stream.Collectors;
import java.util.stream.IntStream;

public class SecondFloor {
    private Node head;
    private int size;

    public SecondFloor() {
        head = null;
        size = 0;
    }

    public boolean isEmpty() {
        return size == 0;
    }

    public int size() {
        return size;
    }

    public void add(Car car) {
        Node newNode = new Node(car);
        if (head == null) {
            head = newNode;
            newNode.next = head;
        } else {
            Node current = head;
            while (current.next != head) {
                current = current.next;
            }
            current.next = newNode;
            newNode.next = head;
        }
        size++;
    }



    public Car remove() {
        if (isEmpty()) {
            throw new RuntimeException("There is no car left on the second floor.");
        }
        if (size == 1) {
            Car data = head.data;
            head = null;
            size--;
            return data;
        }
        int removedCar = joseph(this.size,1);
        Node current = head;
        while (current.next != head) {
            current = current.next;
        }
        for (int i = 0; i < removedCar; i++) {
            current = current.next;
        }
        Node removedNode = current.next;
        current.next = removedNode.next;
        size--;
        head = current.next;
        return removedNode.data;
    }

    public void print() {
        if (isEmpty()) {
            System.out.println("List is empty.");
        } else {
            Node current = head;
            do {
                System.out.println(current.data.getColor());
                current = current.next;
            } while (current != head);
        }
    }

    private static class Node {
        private Car data;
        private Node next;

        public Node(Car data) {
            this.data = data;
            this.next = null;
        }
    }

    public static int joseph(int noOfPeople, int remPosition) {
        int tempPos = remPosition - 1;
        int[] people = new int[noOfPeople];

        for (int i = 0; i < noOfPeople; i++) {
            people[i] = i + 1;
        }

        int iteration = noOfPeople - 1;

        List<Integer> list = IntStream.of(people).boxed().collect(Collectors.toList());

        while (iteration > 0) {
            list.remove(tempPos);
            tempPos += remPosition - 1;
            if (tempPos > list.size() - 1) {
                tempPos = tempPos % list.size();
            }
            iteration--;
        }

        return list.get(0);
    }

}


