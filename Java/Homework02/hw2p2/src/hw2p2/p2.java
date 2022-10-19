/** 
Program description: homework p2 
Author: Oguzhan Atas
E-mail address: oguzhanatas37@gmail.com
Homework Number: 02
Last Changed: 11/10/22
*/

package hw2p2;
import java.util.Scanner; 

public class p2 {

	public static void main(String[] args) {
		Scanner key = new Scanner(System.in);
		System.out.println("Rock-Paper-Scissors");
		System.out.println("P1: Enter your name");
		String p1 = key.nextLine();
		System.out.println("P2: Enter your name");
		String p2 = key.nextLine();
		System.out.println("Instructions=> Rock:R/ Paper:P/Scissors:S/");

		System.out.println("P1: Enter your move");
		String p1move = key.nextLine();
		System.out.println("P2: Enter your move");
		String p2move = key.nextLine();
		
		if(p1move.equals("R") == true || p1move.equals("r") == true) //p1 Rock
		{
			if(p2move.equals("R") == true || p2move.equals("r") == true) //p2 Rock
			{
				System.out.println("Both players option was Rock, Round Draw!");
			}
			else if(p2move.equals("P") == true || p2move.equals("p") == true) //p2 Paper
			{
				System.out.println("Rock versus Paper " + p2 + " wins!! " );
			}
			else if(p2move.equals("S") == true || p2move.equals("s") == true) //p2 Scissors
			{
				System.out.println("Rock versus Scissors " + p1 + " wins!! " );
			}
			else //invalid output p2
			{
				System.out.println("Invalid output from "+ p2 );
			}
		}
		
		else if(p1move.equals("P") == true || p1move.equals("p") == true) //p1 Paper
		{
			if(p2move.equals("R") == true || p2move.equals("r") == true) //p2 Rock
			{
				System.out.println("Paper versus Rock" + p1 + " wins!!");
			}
			else if(p2move.equals("P") == true || p2move.equals("p") == true) //p2 Paper
			{
				System.out.println("Paper versus Paper, round Draw!!" );
			}
			else if(p2move.equals("S") == true || p2move.equals("s") == true) //p2 Scissors
			{
				System.out.println("Paper versus Scissors" + p2 + " wins!!");
			}
			else //invalid output p2
			{
				System.out.println("Invalid output from "+ p2 );
			}
		}
		
		else if(p1move.equals("S") == true || p1move.equals("s") == true) //p1 Scissors
		{
			if(p2move.equals("R") == true || p2move.equals("r") == true) //p2 Rock
			{
				System.out.println("Scissors versus rock" + p2 + " wins!!");
			}
			else if(p2move.equals("P") == true || p2move.equals("p") == true) //p2 Paper
			{
				System.out.println("Scissors versus paper"+p1+ " wins!!");
			}
			else if(p2move.equals("S") == true || p2move.equals("s") == true) //p2 Scissors
			{
				System.out.println("Scissors versus Scissors, round Draw!!");
			}
			else //invalid output p2
			{
				System.out.println("Invalid output from "+ p2 );
			}
		}
		else //invalid output p2
		{
			System.out.println("Invalid output from "+ p1 );
		}
		
		
	}

}
