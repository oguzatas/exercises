package AssignmentOne.GainCalculator;



import java.util.Scanner;

public class ConsoleUI {
    public static void main(String[] args)
    {
        System.out.println("How many cars do you want to add?");
        Scanner sc = new Scanner(System.in);
        int N = sc.nextInt();
        ParkingSimulation autopark = new ParkingSimulation(N);
        ParkingSimulationPQ autopark2 = new ParkingSimulationPQ(N);

        new CarFactory().buildCars(N,autopark,autopark2);

        autopark.removeAllCars();
        System.out.println("Average process completion Time:" + autopark.getTotalProcessTime() / N);
        System.out.println("Average transaction completion Time:" + autopark.getTotalTransactionTime() /N);
        System.out.println("***********************************");

        autopark2.removeAllCars();
        System.out.println("Average process completion Time:" + autopark2.getTotalProcessTime() / N);
        System.out.println("Average transaction completion Time:" + autopark2.getTotalTransactionTime() /N);
        System.out.println("***********************************");

        int pq = autopark2.getTotalTransactionTime() /N;
        int nq = autopark.getTotalTransactionTime() /N;
        System.out.println(pq);
        System.out.println(nq);
        System.out.println("% Gain in priority queue:" + ((double)(nq - pq) / nq)*100 );

    }

}
