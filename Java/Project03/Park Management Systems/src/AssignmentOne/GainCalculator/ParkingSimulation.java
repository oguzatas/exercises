package AssignmentOne.GainCalculator;



import java.util.LinkedList;
import java.util.Queue;

public class ParkingSimulation {
    private Queue<Car> parkingQueue;
    private int maxParkingSpaces;

    public int getTotalProcessTime() {
        return totalProcessTime;
    }

    public void setTotalProcessTime(int totalProcessTime) {
        this.totalProcessTime += totalProcessTime;
    }

    private int totalProcessTime;

    private int totalTransactionTime;
    public int getTotalTransactionTime() {
        return totalTransactionTime;
    }

    public void setTotalTransactionTime(int totalTransactionTime) {
        this.totalTransactionTime = totalTransactionTime;
    }

    public ParkingSimulation(int maxParkingSpaces) {
        this.parkingQueue = new LinkedList<>();
        this.maxParkingSpaces = maxParkingSpaces;
    }

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
            Car car = parkingQueue.remove();
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
