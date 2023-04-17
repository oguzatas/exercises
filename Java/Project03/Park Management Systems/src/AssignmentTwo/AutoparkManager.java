package AssignmentTwo;

import java.util.Arrays;
import java.util.Queue;
import java.util.Random;
import java.util.Stack;

public class AutoparkManager {

    static GroundFloor floorOne = new GroundFloor();
    static Underground floorZero = new Underground();
    static SecondFloor floorTwo = new SecondFloor();

     AutoparkManager()
     {

     }

    public static void removeAllCars()
    {
        while(!floorOne.isEmpty())
        {

            System.out.println("***************************************************************");

            //print
            System.out.println("First Floor****************");
            System.out.println();
            floorOne.printQueue();
            System.out.println();

            System.out.println("Underground****************");
            System.out.println();
            floorZero.printStack();
            System.out.println();

            System.out.println("Second Floor****************");
            System.out.println();
            floorTwo.print();
            System.out.println();

            //remove
            Car removed;
            removed = floorOne.dequeue();
            System.out.println(removed.getColor() + " Car exits the Autopark");
            Random rd = new Random();
            if(rd.nextBoolean() && !floorZero.isEmpty())
            {
                removed = floorZero.pop();
                System.out.println(removed.getColor() +" Car leaves the ground floor, enqueues on first floor to exit. ");
                floorOne.enqueue(removed);
            }
            else if (!floorTwo.isEmpty())
            {
                removed = floorTwo.remove();
                System.out.println(removed.getColor() +" Car leaves the second floor, enqueues on first floor to exit. ");
                floorOne.enqueue(removed);
            }
            System.out.println("***************************************************************");
        }
    }


    public static void main(String[] args)
    {
        floorOne.enqueue(new Car("1"));
        floorOne.enqueue(new Car("2"));
        floorOne.enqueue(new Car("3"));
        floorOne.enqueue(new Car("4"));
        floorOne.enqueue(new Car("5"));
        floorOne.enqueue(new Car("6"));
        floorOne.enqueue(new Car("7"));
        floorOne.enqueue(new Car("8"));
        floorOne.enqueue(new Car("9"));
        floorOne.enqueue(new Car("10"));
        floorOne.enqueue(new Car("11"));
        floorOne.enqueue(new Car("12"));
        floorOne.enqueue(new Car("13"));
        floorOne.enqueue(new Car("14"));
        floorOne.enqueue(new Car("15"));

        floorZero.push(new Car("20"));
        floorZero.push(new Car("21"));
        floorZero.push(new Car("22"));
        floorZero.push(new Car("23"));
        floorZero.push(new Car("24"));
        floorZero.push(new Car("25"));
        floorZero.push(new Car("26"));
        floorZero.push(new Car("27"));
        floorZero.push(new Car("28"));
        floorZero.push(new Car("29"));
        floorZero.push(new Car("30"));
        floorZero.push(new Car("31"));
        floorZero.push(new Car("32"));
        floorZero.push(new Car("33"));
        floorZero.push(new Car("34"));
        floorZero.push(new Car("35"));

        floorTwo.add(new Car("40"));
        floorTwo.add(new Car("41"));
        floorTwo.add(new Car("42"));
        floorTwo.add(new Car("43"));
        floorTwo.add(new Car("44"));
        floorTwo.add(new Car("45"));
        floorTwo.add(new Car("46"));
        floorTwo.add(new Car("47"));
        floorTwo.add(new Car("48"));
        floorTwo.add(new Car("49"));
        floorTwo.add(new Car("50"));
        floorTwo.add(new Car("51"));
        floorTwo.add(new Car("52"));
        floorTwo.add(new Car("53"));
        floorTwo.add(new Car("54"));
        floorTwo.add(new Car("55"));



        removeAllCars();
    }





}
