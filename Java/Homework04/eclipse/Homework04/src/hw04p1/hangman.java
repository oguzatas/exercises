package hw04p1;


public class hangman {

    private  String secretWord;
    private  String disguisedWord;
    private int numberOfGuesses=0;
    private int numberOfIncorrectGuesses=0;

    public void setSecretWord(String secretWord) {
        this.secretWord = secretWord;
    }

    public String getDisguisedWord() {
        return disguisedWord;
    }

    public void setDisguisedWord() {

        int x = this.secretWord.length();
        String e = "";
        for(int y=0 ; y<x ; y++)
        {
            e = e + "?";
        }

        this.disguisedWord = e;
        
        }

    public void makeGuess(char c)
    {
    	
    	int position = this.secretWord.indexOf(c);
    	
    	
    	
    	numberOfGuesses++;
    	if(position<0)
    	{
    		numberOfIncorrectGuesses++;
    	}
    	
    	
    	for (    position = this.secretWord.indexOf(c);
    		     position >= 0;
    		     position = this.secretWord.indexOf(c, position+ 1))
    		{
    		this.disguisedWord = this.disguisedWord.substring(0,position)+ c +this.disguisedWord.substring(position+1);
    		}
    	
  	
    	{   		   		
    		
    		 System.out.println(this.disguisedWord);
    	} 
       
       
    }

    public String getSecretWord() {
        return secretWord;
    }

    public int getNumberOfGuesses() {
        return numberOfGuesses;
    }

    public int getNumberOfIncorrectGuesses() {
        return numberOfIncorrectGuesses;
    }

    public boolean isFound()
    {
    	if(this.secretWord.equals(this.disguisedWord) == true)
    	{
    		return true;
    	}
    	else
    	{
    		return false;
    	}
        
    }

}
