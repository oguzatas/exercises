package hw03p2;

import java.util.Scanner;

/*

Program description: part1

Author: Oguzhan Atas

E-mail address: oguzhanatas37@gmail.com

Homework Number: 03

Last Changed: 18/10/22

*/

public class problem02 {

	  public static void main(String[] args) {
	        Scanner k = new Scanner(System.in);
	        int N = k.nextInt();
	        System.out.println("you have "+N +" dollars");
	        int chocolatesBought=0;
	        int coupon = 0;
	        for(int i=N;i>=1;i--)
	        {
	            if(coupon == 6)
	            {
	                coupon = 1;
	                chocolatesBought++;
	            }
	            chocolatesBought++;
	            coupon++;

	        }
	        System.out.println("you can buy "+chocolatesBought+" chocolates and you will have "+coupon+" coupons left");

	    }

	}


