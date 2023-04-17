package AssignmentOne.PartB;

import java.util.Comparator;
import java.util.PriorityQueue;

public class ParkingSimulation {
    private PriorityQueue<Car> parkingQueue;
    private int maxParkingSpaces;
    private int totalTransactionTime;

    public ParkingSimulation(int maxParkingSpaces) {
        this.parkingQueue = new PriorityQueue<>(Comparator.comparingInt(Car::getProcessTime));
        this.maxParkingSpaces = maxParkingSpaces;
    }

    public int getTotalTransactionTime() {
        return totalTransactionTime;
    }

    public void setTotalTransactionTime(int totalTransactionTime) {
        this.totalTransactionTime = totalTransactionTime;
    }

    public int getTotalProcessTime() {
        return totalProcessTime;
    }

    public void setTotalProcessTime(int totalProcessTime) {
        this.totalProcessTime += totalProcessTime;
    }

    private int totalProcessTime;

    public boolean park(Car car) {
        if (parkingQueue.size() < maxParkingSpaces) {
            parkingQueue.add(car);
            System.out.println(car.getLicensePlate() + " has parked successfully.");
            return true;
        } else {
            System.out.println("Sorry, the parking lot is full. " + car.getLicensePlate() + " cannot park.");
            return false;
        }
    }

    public Car unpark() {
        if (!parkingQueue.isEmpty()) {
            Car car = parkingQueue.poll();
            System.out.println(car.getLicensePlate() + " has left the parking lot.");
            return car;
        } else {
            System.out.println("There are no cars parked in the lot.");
            return null;
        }
    }

    public Car peek() {
        if (!parkingQueue.isEmpty()) {
            Car car = parkingQueue.peek();
            System.out.println("The car at the front of the queue is " + car.getLicensePlate() + ".");
            return car;
        } else {
            System.out.println("There are no cars parked in the lot.");
            return null;
        }
    }

    public int getNumParkedCars() {
        return parkingQueue.size();
    }

    public void removeAllCars() {
        while(this.peek() != null)
        {
            System.out.println("*******************************************");
            Car car = this.peek();
            int processTime = this.unpark().getProcessTime();
            System.out.println("process last "+ processTime + " seconds.");
            setTotalProcessTime(processTime);
            System.out.println(car.getLicensePlate()+" plated car waited total of "+getTotalProcessTime()+" seconds.");
            setTotalTransactionTime(getTotalTransactionTime()+getTotalProcessTime());
            System.out.println("*******************************************");

        }
    }
}

