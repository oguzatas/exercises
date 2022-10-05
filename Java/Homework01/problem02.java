/**

Program description: Second problem

Author: Oguzhan Atas

E-mail address: oguzhanatas37@gmail.com

Homework Number: 01

Last Changed: 03/10/22

*/


import java.util.Scanner;  // Import the Scanner class

class problem02 {
  public static void main(String[] args) {
    Scanner sc = new Scanner(System.in);  // Create a Scanner object
    System.out.println("Enter your weight/pounds");
    float weight = sc.nextFloat();
    System.out.println("Enter your height/inches");
    float height = sc.nextFloat();
    System.out.println("Enter your age/years");
    int age = sc.nextInt();
    
    float bmrwoman = (float) (655 +  (4.3 * weight) + (4.7 * height) - (4.7 * age));
    
    float bmrman = (float) (66 +(6.3 * weight) + (12.9 * height) - (6.8 * age));
    
    System.out.println("A woman must consume " + bmrwoman/230 + "bars of chocolate to maintain her weight");
  
    System.out.println("A man must consume " + bmrman/230 + "bars of chocolate to maintain his weight");
  
  }
}





//The calories needed for a woman to maintain her weight is:
//
//BMR = 655 + (4.3 * weight in pounds) + (4.7 * height in inches) - (4.7 * age in years)
//
// 
//
//The calories needed for a man to maintain his weight is:
//
//BMR = 66 + (6.3 * weight in pounds) + (12.9 * height in inches) - (6.8 * age in years)

//A typical chocolate bar will contain around 230 calories.