package hw02;// Java program to convert time from 24 hour
// to 12 hour format

import java.sql.Time;
import java.util.*;
// Convert Function which takes in
// 24hour time and convert it to
// 12 hour format
class converter
{

    static void convert12(String str) throws TimeFormatException {
// Get Hours



        int h1 = (int)str.charAt(0) - '0';
        int h2 = (int)str.charAt(1)- '0';
        int m1 = (int)str.charAt(3) - '0';
        int m2 = (int)str.charAt(4)- '0';
        int s1 = (int)str.charAt(6) - '0';
        int s2 = (int)str.charAt(7)- '0';
        int hh = h1 * 10 + h2;
        int mm = m1 * 10 + m2;
        int ss = s1 * 10 + s2;

        if(str.length()!=8)
        {
            throw new TimeFormatException("Invalid Format");
        }

        if(hh>24)
        {
            throw new TimeFormatException("Invalid hour Input");
        }


        if(mm>59)
        {
            throw new TimeFormatException("Invalid minute Input");
        }

        if(ss>59)
        {
            throw new TimeFormatException("Invalid second Input");
        }


        // Finding out the Meridien of time
        // ie. AM or PM
        String Meridien;
        if (hh < 12) {
            Meridien = "AM";
        }
        else
            Meridien = "PM";

        hh %= 12;

        // Handle 00 and 12 case separately
        if (hh == 0) {
            System.out.print("12");

            // Printing minutes and seconds
            for (int i = 2; i < 8; ++i) {
                System.out.print(str.charAt(i));
            }
        }
        else {
            System.out.print(hh);
            // Printing minutes and seconds
            for (int i = 2; i < 8; ++i) {
                System.out.print(str.charAt(i));
            }
        }

        // After time is printed
        // cout Meridien
        System.out.println(" "+Meridien);
    }

    //Driver code
    public static void main(String ar[]) throws TimeFormatException {
        Scanner sc = new Scanner(System.in);



        boolean again = true;

        while(again)

        {
            System.out.println("Enter time in 24-hour notation within a format HH:MM:SS");
            String str = sc.next();
            convert12(str);
            System.out.println("Again true/false");

            again = sc.nextBoolean();
        }








    }
}