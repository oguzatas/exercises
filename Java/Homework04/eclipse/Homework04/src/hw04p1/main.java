package hw04p1;
import java.util.Scanner;

public class main {

	public static void main(String[] args) {
		
		 Scanner s = new Scanner(System.in);
	     hangman h = new hangman();
	     
	   //set secret word
	        System.out.println("Please enter your secret word");
	        String sWord = s.nextLine();
	        h.setSecretWord(sWord);
	        h.setDisguisedWord();
	        String word = h.getDisguisedWord();
	        System.out.println(word);	
	        //make guess section
	        
	       
	        
	        while(h.isFound() != true)
	        {
	        	char ch = s.next().charAt(0); 
	        	
	        	h.makeGuess(ch);
	        	
	        }
	        String hh = h.getDisguisedWord();
	        System.out.println(hh);
	        
	        int guess=h.getNumberOfGuesses();
	        int wGuess=h.getNumberOfIncorrectGuesses();
	        System.out.println("Number of total counts =>"+guess);
	        System.out.println("Number of total counts =>"+wGuess);
	        
	        

	        

	        //
		
	}

}
