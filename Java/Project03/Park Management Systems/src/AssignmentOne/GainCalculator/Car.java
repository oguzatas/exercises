package AssignmentOne.GainCalculator;

public class Car {

    public Car(int licensePlate) {
        this.licensePlate = licensePlate;
    }

    public int getLicensePlate() {
        return licensePlate;
    }

    public int getProcessTime() {
        return processTime;
    }

    public void setProcessTime(int processTime) {
        this.processTime = processTime;
    }

    public void setLicensePlate(int licensePlate) {
        this.licensePlate = licensePlate;
    }


    private int processTime;

    private int licensePlate;
}
