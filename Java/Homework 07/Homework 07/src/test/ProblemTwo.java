package test;

import java.util.PriorityQueue;
import java.util.Queue;

public class ProblemTwo {
    private int[] queue;
    private int front;
    private int rear;
    private int size;

    public ProblemTwo() {
        queue = new int[20];
        front = 0;
        rear = -1;
        size = 0;
    }

    public void enqueue(int PlayerID, int priority) {
        if (size == 20) {
            System.out.println("Queue is full.");
            return;
        }
        int i;
        for (i = rear; i >= front; i--) {
            if (priority > queue[i % 20]) {
                queue[(i + 1) % 20] = queue[i % 20];
            } else {
                break;
            }
        }
        queue[(i + 1) % 20] = PlayerID;
        rear = (rear + 1) % 20;
        size++;
    }

    public int dequeue() {
        if (size == 0) {
            System.out.println("Queue is empty.");
            return -1;
        }
        int item = queue[front];
        front = (front + 1) % 20;
        size--;
        return item;
    }

    public int front() {
        if (size == 0) {
            System.out.println("Queue is empty.");
            return -1;
        }
        return queue[front];
    }

    public int rear() {
        if (size == 0) {
            System.out.println("Queue is empty.");
            return -1;
        }
        return queue[rear];
    }

    public boolean isEmpty() {
        return size == 0;
    }

    public boolean isFull() {
        return size == 20;
    }

    public static void main(String[] args) {
        ProblemTwo game = new ProblemTwo();
        game.enqueue(100,1);
        game.enqueue(101,2);
        game.enqueue(102,3);
        game.enqueue(103,4);
        game.enqueue(104,5);
        System.out.println(game.rear());
        System.out.println(game.front());
        game.dequeue();
        game.dequeue();
        game.dequeue();
        System.out.println(game.rear());
        System.out.println(game.front());


    }
}
