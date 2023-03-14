package ChapterOne;

import java.util.HashMap;
import java.util.Map;

//PROBLEM 1:
    public class LinkedList {

        private Node head;

    public Node getHead() {
        return head;
    }

    private int size;

        public LinkedList() {
            head = null;
            size = 0;
        }

        public int size() {
            return size;
        }

        public boolean isEmpty() {
            return head == null;
        }

        public void insertFirst(int data) {
            Node newNode = new Node(data);
            newNode.setNext(head);
            head = newNode;
            size++;
        }

        public void insertLast(int data) {
            Node newNode = new Node(data);
            if (isEmpty()) {
                head = newNode;
            } else {
                Node current = head;
                while (current.getNext() != null) {
                    current = current.getNext();

                }
                current.setNext(newNode);
            }
            size++;
        }

        public void insertAfter(int key, int data) {
            Node current = head;
            while (current != null && current.getData() != key) {
                current = current.getNext();
            }
            if (current != null) {
                Node newNode = new Node(data);
                newNode.setNext(current.getNext());
                current.setNext(newNode);
                size++;
            }
        }

        public Node deleteFirst() {
            if (isEmpty()) {
                return null;
            } else {
                Node temp = head;
                head = head.getNext();
                temp.setNext(null);
                size--;
                return temp;
            }
        }

        public Node deleteLast() {
            if (isEmpty()) {
                return null;
            } else if (size == 1) {
                Node temp = head;
                head = null;
                size--;
                return temp;
            } else {
                Node current = head;
                while (current.getNext().getNext() != null) {
                    current = current.getNext();
                }
                Node temp = current.getNext();
                current.setNext(null);
                size--;
                return temp;
            }
        }

        public Node deleteNode(int key) {
            if (isEmpty()) {
                return null;
            } else {
                Node current = head;
                Node previous = null;
                while (current != null && current.getData() != key) {
                    previous = current;
                    current = current.getNext();
                }
                if (current == null) {
                    return null;
                } else if (current == head) {
                    head = current.getNext();
                    current.setNext(null);
                    size--;
                    return current;
                } else {
                    previous.setNext(current.getNext());
                    current.setNext(null);
                    size--;
                    return current;
                }
            }
        }

        // PROBLEM 2, Function to reverse the given linked list

        public Node reverseList() {
            Node prev = null;
            Node current = this.head;
            while (current != null) {
                Node next = current.getNext();
                current.setNext(prev);
                prev = current;
                current = next;
            }

            Node ptr = prev;



            while (ptr != null)
            {
                System.out.println(ptr.getData());
                ptr = ptr.getNext();
            }

            return prev;
        }

        //PROBLEM 3, a function to remove continuous nodes indicated by programmer

        public static Node removeContinuousNodes(Node head, int K) {
            Node dummy = new Node(-1);
            dummy.setNext(head);
            Map<Integer, Node> map = new HashMap<>();
            map.put(0, dummy);
            int sum = 0;
            while (head != null) {
                sum += head.getData();
                if (map.containsKey(sum - K)) {
                    Node prev = map.get(sum - K);
                    Node end = head;
                    sum = sum - K;
                    while (prev.getNext() != end) {
                        sum += prev.getNext().getData();
                        map.remove(sum);
                        prev.setNext(prev.getNext().getNext());
                    }
                } else {
                    map.put(sum, head);
                }
                head = head.getNext();
            }

            Node ptr = dummy.getNext();



            while (ptr != null)
            {
                System.out.println(ptr.getData());
                ptr = ptr.getNext();
            }

            return dummy.getNext();
        }

    }


