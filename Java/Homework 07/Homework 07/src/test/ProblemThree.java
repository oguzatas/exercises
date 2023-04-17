package test;


import java.util.PriorityQueue;
import java.util.Queue;

public class ProblemThree {

    public static class Customer implements Comparable<Customer> {
        int arrivalTime;
        int transactionTime;

        public Customer(int arrivalTime, int transactionTime) {
            this.arrivalTime = arrivalTime;
            this.transactionTime = transactionTime;
        }

        @Override
        public int compareTo(Customer other) {
            return Integer.compare(this.arrivalTime, other.arrivalTime);
        }
    }

    public static double simulateCheckout(Queue<Customer> queue) {
        int currentTime = 0;
        int totalWaitingTime = 0;
        int customerCount = 0;
        PriorityQueue<Customer> pq = new PriorityQueue<>();

        while (!queue.isEmpty() || !pq.isEmpty()) {
            if (!queue.isEmpty() && queue.peek().arrivalTime <= currentTime) {
                pq.add(queue.poll());
                continue;
            }

            if (pq.isEmpty()) {
                pq.add(queue.poll());
                currentTime = pq.peek().arrivalTime;
                continue;
            }

            Customer customer = pq.poll();
            int waitingTime = currentTime - customer.arrivalTime;
            totalWaitingTime += waitingTime;
            customerCount++;
            System.out.println("Customer arrived at " + customer.arrivalTime + ", started checkout at " + currentTime + ", finished checkout at " + (currentTime + customer.transactionTime) + ", waiting time: " + waitingTime + " seconds");
            currentTime += customer.transactionTime;

            while (!queue.isEmpty() && queue.peek().arrivalTime <= currentTime) {
                pq.add(queue.poll());
            }
        }

        double averageWaitingTime = (double) totalWaitingTime / customerCount;
        System.out.println("Total waiting time: " + totalWaitingTime + " seconds");
        System.out.println("Average waiting time per customer: " + averageWaitingTime + " seconds");
        return averageWaitingTime;
    }

    public static void main(String[] args) {
        Queue<Customer> queue = new PriorityQueue<>();
        queue.add(new Customer(0, 10));
        queue.add(new Customer(5, 5));
        queue.add(new Customer(10, 20));
        queue.add(new Customer(15, 12));
        queue.add(new Customer(20, 3));

        double averageWaitingTime = simulateCheckout(queue);
    }
}

