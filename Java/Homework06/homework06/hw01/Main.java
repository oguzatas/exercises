package hw01;

import java.util.Scanner;

public class Main {


	public static void main(String[] args) {
		
		ServiceRequest sr = new ServiceRequest();
		Scanner input = new Scanner(System.in);


		boolean a = true;
		int x;


		System.out.println("Welcome to Customer Service");
		do {
			System.out.println();
			System.out.println("1-Add a name");
			System.out.println("2-Remove a name");
			System.out.println("3-Find Name");
			System.out.println("4-Queue count");
			System.out.println("0-Exit");
			x = input.nextInt();
			switch(x) {
			case 1: {
				sr.addName();
				break;
			}
			case 2: {
				sr.removeName();
				break;
			}	
			case 3: {
				sr.getName();
				break;
			}	
			case 4: {
				sr.getLined();
				break;
			}	
			case 0: {
				a = false;
				break;
			}	
			default:
				System.out.println("Invalid option");
			}
		}while(a);
		input.close();
	}
}
