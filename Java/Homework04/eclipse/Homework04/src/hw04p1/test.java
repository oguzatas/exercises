package hw04p1;

public class test {

	public static void main(String[] args) {
		
		String word = "hello";
		int position = 1;
		word = word.substring(0,position)+ "x" + word.substring(position+1); 
		
		System.out.println(word);
		
	}

}
