package AssignmentOne.GainCalculator;

import java.util.Random;

public class CarFactory {

    private static int N;
    private static int plateNumGiver;
    Random rand = new Random();

    public CarFactory() {




    }

    public void buildCars(int N, ParkingSimulation autopark, ParkingSimulationPQ autopark2)
    {
        plateNumGiver = 0;
        for (int i=0;i<N;i++)
        {
            Car Carptr = new Car(plateNumGiver);
            Carptr.setProcessTime(rand.nextInt(290)+10);
            plateNumGiver++;
            autopark.park(Carptr);
            autopark2.park(Carptr);
        }
    }
}
