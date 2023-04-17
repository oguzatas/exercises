package ChapterTwo;

import java.util.Scanner;
import java.util.Stack;

public class BracketMatcher {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        System.out.print("Enter a string: ");
        String inputString = scanner.nextLine();

        boolean isMatching = bracketMatcher(inputString);

        System.out.println(isMatching);
    }

    public static boolean bracketMatcher(String inputString) {
        Stack<Character> stack = new Stack<Character>();

        for (int i = 0; i < inputString.length(); i++) {
            char c = inputString.charAt(i);

            if (c == '(' || c == '[' || c == '{') {
                stack.push(c);
            } else if (c == ')' || c == ']' || c == '}') {
                if (stack.isEmpty()) {
                    return false;
                }

                char top = stack.peek();
                if ((c == ')' && top == '(') || (c == ']' && top == '[') || (c == '}' && top == '{')) {
                    stack.pop();
                } else {
                    return false;
                }
            }
        }

        return stack.isEmpty();
    }
}
