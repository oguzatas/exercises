package hw03p1;

/**

Program description: part1

Author: Oguzhan Atas

E-mail address: oguzhanatas37@gmail.com

Homework Number: 03

Last Changed: 18/10/22

*/


public class problem01 {

	public static void main(String[] args) {
		
		String code = ":mmZ\\dxZmx]Zpgya";
		int codelen = code.length();
		
		
		for(int i=0 ;i<100 ;i++)
		{
			for(int j=0;j<codelen;j++)
			{
				int OriginalChar = code.charAt(j);
				if (code.charAt(j) + i > 126) 
					 
				 {
						
					  int EncryptedChar = 32 + ((OriginalChar + i) - 127);
					  char EncryptedChar2 = (char) EncryptedChar;
					  System.out.print(EncryptedChar2);
					
				 }
				 else
				 {
				      int EncryptedChar = (OriginalChar + i);
				      char EncryptedChar2 = (char) EncryptedChar;
					  System.out.print(EncryptedChar2);
				 }
			 }
				System.out.println(" ");
			
			
			
		}
		
		 

	      

	 
	}

}
