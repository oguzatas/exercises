/**

Program description: third problem

Author: Oguzhan Atas

E-mail address: oguzhanatas37@gmail.com

Homework Number: 01

Last Changed: 04/10/22

*/

import java.util.Scanner;  
import javax.swing.*; 

class problem03 {
  public static void main(String[] args) {
	  JFrame f;  
    Scanner sc = new Scanner(System.in);  // Create a Scanner object
    f=new JFrame();  // frame
    
    String date=JOptionPane.showInputDialog(f,"Enter Name"); 
    
//    String date = sc.nextLine();  // Read user input
    
    String[] arrayDate  = date.split("/");
    
    JOptionPane.showMessageDialog(f,arrayDate[1]+"."+arrayDate[0]+"."+arrayDate[2]);
    
  }
}