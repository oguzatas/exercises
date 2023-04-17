package AssignmentTwo;

import java.util.LinkedList;

public class GroundFloor {

        private LinkedList<Car> queue;

        public GroundFloor() {
            queue = new LinkedList<Car>();
        }

        public void enqueue(Car car) {
            queue.addLast(car);
        }

        public Car dequeue() {
            if (queue.isEmpty()) {
                throw new RuntimeException("Queue is empty");
            }
            return queue.removeFirst();
        }

        public Car peek() {
            if (queue.isEmpty()) {
                throw new RuntimeException("Queue is empty");
            }
            return queue.getFirst();
        }

        public boolean isEmpty() {
            return queue.isEmpty();
        }

        public int size() {
            return queue.size();
        }

    public void printQueue() {
        if (queue.isEmpty()) {
            System.out.println("There is no car on the queue.");
        } else {
            System.out.print("Queue: ");
            for (Car car : queue) {
                System.out.print(car.getColor() + " ");
            }
            System.out.println();
        }
    }

    }

