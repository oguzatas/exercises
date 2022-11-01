package hw04p2;

public class ConcertPromoter {
	String bandName;
	int venueCapacity;
	int ticketsSold;
	int priceOfTSbyPhone;
	int priceOfTSbyVenue;
	int totalSalesAmount;
	
	
	//SETTERS
	
	
	 public void setBandName(String bandName) {
	        this.bandName = bandName;
	    }
	 
	 public void setVenueCapacity(int venueCapacity) {
	        this.venueCapacity = venueCapacity;
	    }
	 
	 public void setPriceOfTSbyPhone(int priceOfTSbyPhone) {
	        this.priceOfTSbyPhone = priceOfTSbyPhone;
	    }
	 
	 public void setPriceOfTSbyVenue(int priceOfTSbyVenue) {
	        this.priceOfTSbyVenue = priceOfTSbyVenue;
	    }
	 public void setTotalSalesAmount(int totalSalesAmount) {
	        this.totalSalesAmount = totalSalesAmount;
	    }
	 
	 //GETTERS
	 
	 
	 public int getTicketsSold() {
	        return ticketsSold;
	    }
	 
	 public int getTicketsRemaining()
	 {
		 return 1;
	 }
	 
	 public int getTotalSalesAmount() {
	        return totalSalesAmount;
	    }
	
	 //SET
	 
	 public boolean setCurrentSalesMode(boolean arg)
	 {
		 return arg;
	 }
	
}


