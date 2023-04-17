package ChapterThree;

import java.util.*;

public class RunningMedianQueue {
    private Queue<Integer> minHeap;
    private Queue<Integer> maxHeap;

    public RunningMedianQueue() {
        minHeap = new PriorityQueue<>();
        maxHeap = new PriorityQueue<>(Collections.reverseOrder());
    }

    public void enqueue(int x) {
        if (maxHeap.isEmpty() || x <= maxHeap.peek()) {
            maxHeap.offer(x);
        } else {
            minHeap.offer(x);
        }

        if (maxHeap.size() > minHeap.size() + 1) {
            minHeap.offer(maxHeap.poll());
        } else if (minHeap.size() > maxHeap.size()) {
            maxHeap.offer(minHeap.poll());
        }
    }

    public int dequeue() {
        if (maxHeap.isEmpty()) {
            throw new NoSuchElementException("Queue is empty");
        }
        int x = maxHeap.poll();
        if (maxHeap.size() < minHeap.size()) {
            maxHeap.offer(minHeap.poll());
        }
        return x;
    }

    public double median() {
        if (maxHeap.isEmpty()) {
            throw new NoSuchElementException("Queue is empty");
        }
        if (maxHeap.size() == minHeap.size()) {
            return (maxHeap.peek() + minHeap.peek()) / 2.0;
        } else {
            return maxHeap.peek();
        }
    }
}
