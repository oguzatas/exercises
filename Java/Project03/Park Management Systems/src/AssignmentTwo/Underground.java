package AssignmentTwo;


import java.util.Arrays;
import java.util.Stack;

public class Underground {
        private Node<Car> top;
        private int size;

        public Underground() {
            top = null;
            size = 0;
        }



        public boolean isEmpty() {
            return size == 0;
        }

        public int size() {
            return size;
        }

        public void push(Car car) {
            Node<Car> newNode = new Node<>(car);
            newNode.next = top;
            top = newNode;
            size++;
        }

        public Car pop() {
            if (isEmpty()) {
                throw new RuntimeException("Stack is empty.");
            }
            Car car = top.data;
            top = top.next;
            size--;
            return car;
        }

        public Car peek() {
            if (isEmpty()) {
                throw new RuntimeException("Stack is empty.");
            }
            return top.data;
        }

    public void printStack() {
        if (isEmpty()) {
            System.out.println("Stack is empty.");
            return;
        }
        System.out.println("Current Cars in the underground:");
        Node<Car> current = top;
        while (current != null) {
            System.out.println(current.data.getColor());
            current = current.next;
        }
    }


        private static class Node<Car> {
            private Car data;
            private Node<Car> next;

            public Node(Car data) {
                this.data = data;
                this.next = null;
            }
        }
    }



