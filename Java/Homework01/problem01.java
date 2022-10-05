/**

Program description: First problem

Author: Oguzhan Atas

E-mail address: oguzhanatas37@gmail.com

Homework Number: 01

Last Changed: 03/10/22

*/

import java.util.Scanner;
public class problem01
{
    public static void main(String[] args)
    {       
        Scanner keyboard = new Scanner(System.in);
        System.out.println("Please enter your sentence");
        String sentence =keyboard.nextLine();
        System.out.println(sentence);
        
        String[] newSentence = sentence.split(" "); // using split method to get every word
                      
        
        
        for (int i = 1; i < newSentence.length; i++) // 
        {
            
        	if(i==1)
        	{
        		String firstElement = newSentence[i].substring(0, 1).toUpperCase() + newSentence[i].substring(1);
        		System.out.print(firstElement+" ");
        	}
        	else 
        	{
        		System.out.print(newSentence[i].toLowerCase()+" "); 
        	}       	       	      	                        
        }
        
        System.out.print(newSentence[0].toLowerCase()+" ");
                                                   
    }
}