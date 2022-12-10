package hw01;

import java.util.Scanner;

public class ServiceRequest {

	Scanner input = new Scanner(System.in);
	private String[] names = new String[10];

	private String name;
	private int array=0;
	private int capacity = 10;
	private int i;
	public void addName(){
		System.out.println("Enter a name: ");
		name = input.next();
		try
		{
			add(name);
		}
		catch(Exception e)
		{
			System.out.println(e.getMessage());
		}
	}
	
	private void add(String name) throws ServiceBackUpException {
		if(array == (capacity-1)) {
			throw new ServiceBackUpException("There is no space");
		}else {
			names[array] = name;
			array++;
		}
	}

	public void removeName(){
		
		try {
			remove(name);
		}
		catch(Exception e) {
			System.out.println(e.getMessage());
		}
	}
	
	private void remove(String name) throws NoServiceRequestException {
		boolean x = true;

		System.out.println("Enter the name");


		name = input.next();


		for(i=0;i<array;i++) {
			if(name.equalsIgnoreCase(names[i])) {
				names[i] = null;
				array--;
				x = false;
				break;
			}
		}

		if(x) {
			throw new NoServiceRequestException("Name not found");
		}
	}

	public void getName() {
		int i;
		System.out.println("Enter a number");
		i = input.nextInt();


		if(i>=0 && i<array) {
		System.out.println(names[i]);


		}
		else {
			System.out.println("Invalid input. Try search between 0-"+(array) );
		}
	}




	public void getLined() {
		System.out.println("There are "+array+" people on the line");
	}
}
