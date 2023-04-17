package ChapterTwo;

import java.util.Scanner;

public class ReverseString {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        System.out.print("Enter a string: ");
        String inputString = scanner.nextLine();

        String reversedString = reverseString(inputString);

        System.out.println("Reversed string: " + reversedString);
    }

    public static String reverseString(String inputString) {
        String reversedString = "";
        for (int i = inputString.length() - 1; i >= 0; i--) {
            reversedString += inputString.charAt(i);
        }
        return reversedString;
    }
}