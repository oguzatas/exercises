package AssignmentOne.PartB;

import java.util.Scanner;

public class ConsoleUI {
    public static void main(String[] args)
    {
        System.out.println("How many cars do you want to add?");
        Scanner sc = new Scanner(System.in);
        int N = sc.nextInt();
        ParkingSimulation autopark = new ParkingSimulation(N);

        new CarFactory().buildCars(N,autopark);

        autopark.removeAllCars();

        System.out.println("Average process completion Time:" + autopark.getTotalProcessTime() / N);
        System.out.println("Average transaction completion Time:" + autopark.getTotalTransactionTime() /N);
    }


}


