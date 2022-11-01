package hw04p2;
import java.util.Scanner;

public class main {
	
	public static void main(String[] args) {
		
		
		ConcertPromoter c = new ConcertPromoter();
		Scanner s = new Scanner(System.in);
		System.out.println("Welcome to the concert program!");
		
		
		
		//set 
		System.out.println("Please set a band name");
		String bandname = s.nextLine();
		System.out.println("Please set your venue's capacity");
		int venueCapacity = s.nextInt();
		System.out.println("Please set your phone price");
		int phonePrice = s.nextInt();
		System.out.println("Please set your venue price");
		int venuePrice = s.nextInt();
		c.setBandName(bandname);
		c.setVenueCapacity(venueCapacity);
		c.setPriceOfTSbyVenue(venuePrice);
		c.setPriceOfTSbyPhone(phonePrice);
		c.setTotalSalesAmount(venueCapacity);		
		
		
		while(true)
		{
			System.out.println("Welcome to the menu!");
			System.out.println("Please choose an option");
			System.out.println("1-Sell tickets");
			System.out.println("2-Switch between phone sales/concert venue sales");
			System.out.println("3-Display the number of tickets sold");
			System.out.println("4- Return the total sales of the concert");
			System.out.println("5-Exit application");
			
			
			int option = s.nextInt();
			
			if(option == 1)
			{
				System.out.println("How much tickets do you want to sell");
				int amount = s.nextInt();
				
			}
			else if(option == 2)
			{
				if(c.s)
				{
					
				}
				System.out.println("");
			}
			else if(option == 3)
			{
				
			}
			else if(option == 4)
			{
				
			}
			else if(option == 5)
			{
				break;
			}
			else 
			{
				System.out.println("Invalid Output");
			}
			
			
		}
	}

}
