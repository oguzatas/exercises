package test;

import java.util.Arrays;
import java.util.PriorityQueue;
import java.util.Queue;

public class ProblemOne {
    private int[] queue;
    private int front;
    private int rear;
    private int size;

    public ProblemOne() {
        queue = new int[10];
        front = 0;
        rear = -1;
        size = 0;
    }

    public void enqueue(int item) {
        if (isFull()) {
            resize();
        }
        rear++;
        queue[rear] = item;
        size++;
    }

    public int dequeue() {
        if (isEmpty()) {
            throw new IllegalStateException("Queue is empty");
        }
        int item = queue[front];
        front++;
        size--;
        return item;
    }

    public int peek() {
        if (isEmpty()) {
            throw new IllegalStateException("Queue is empty");
        }
        return queue[front];
    }

    public double median() {
        int[] arr = new int[size];
        for (int x=0;x<size; x++)
        {
            arr[x] = queue[x];
        }

        Arrays.sort(arr);
        int length = arr.length;
        if (length % 2 == 0) {
            int mid = length / 2;
            return (arr[mid - 1] + arr[mid]) / 2.0;
        } else {
            return arr[length / 2];
        }
    }

    public boolean isEmpty() {
        return size == 0;
    }

    public boolean isFull() {
        return size == queue.length;
    }

    public int size() {
        return size;
    }

    private void resize() {
        int[] newQueue = new int[2 * queue.length];
        for (int i = 0; i < size; i++) {
            newQueue[i] = queue[front + i];
        }
        queue = newQueue;
        front = 0;
        rear = size - 1;
    }

    public static void main(String[] args) {
        ProblemOne queue = new ProblemOne();

        queue.enqueue(2);
        queue.enqueue(4);
        queue.enqueue(6);
        queue.enqueue(8);
        queue.enqueue(10);
        queue.dequeue();
        System.out.println(queue.median());

    }
}