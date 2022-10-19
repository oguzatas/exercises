package hw2;
import java.util.Scanner;  // Import the Scanner class

public class p1 {

	public static void main(String[] args) {
		
		Scanner key = new Scanner(System.in);
		System.out.println("How much money can you spend for Erdem Saglam's feel?");
		int wallet = key.nextInt();
		
		if (wallet > 21600)
		{
			int min = wallet/15;
			int h = min/60;
			int day = h/24;
			System.out.println("Onan family can afford "+day+" days "+ h%24 + " hours " + min%60 +" minutes");
		}
		else if (wallet > 900)
		{
			int min = wallet/15;
			int h = min/60;
			System.out.println("Onan family can afford " + h%24 + " hours " + min%60 +" minutes");
		}
		else 
		{
			int min = wallet/15;
			System.out.println("Onan family can afford " + min%60 +" minutes");
			
		}
	}

}
