package ChapterTwo;

import java.util.*;

public class InfixToPostfix {

    public static String infixToPostfix(String infix) {
        Map<Character, Integer> precedence = new HashMap<>();
        precedence.put('+', 1);
        precedence.put('-', 1);
        precedence.put('*', 2);
        precedence.put('/', 2);

        Stack<Character> stack = new Stack<>();
        StringBuilder postfix = new StringBuilder();

        for (char c : infix.toCharArray()) {
            if (Character.isLetterOrDigit(c)) {
                postfix.append(c);
            } else if (c == '(') {
                stack.push(c);
            } else if (c == ')') {
                while (!stack.isEmpty() && stack.peek() != '(') {
                    postfix.append(stack.pop());
                }
                if (stack.isEmpty()) {
                    throw new IllegalArgumentException("Invalid infix expression: mismatched parentheses");
                }
                stack.pop(); // pop the '('
            } else {
                while (!stack.isEmpty() && stack.peek() != '(' && precedence.get(stack.peek()) >= precedence.get(c)) {
                    postfix.append(stack.pop());
                }
                stack.push(c);
            }
        }

        while (!stack.isEmpty()) {
            char c = stack.pop();
            if (c == '(') {
                throw new IllegalArgumentException("Invalid infix expression: mismatched parentheses");
            }
            postfix.append(c);
        }

        return postfix.toString();
    }

    public static int postfixEvaluation(String postfix) {
        Stack<Integer> stack = new Stack<>();

        for (char c : postfix.toCharArray()) {
            if (Character.isLetterOrDigit(c)) {
                throw new IllegalArgumentException("Invalid postfix expression: non-operator/non-operand character");
            } else if (c == '+') {
                int b = stack.pop();
                int a = stack.pop();
                stack.push(a + b);
            } else if (c == '-') {
                int b = stack.pop();
                int a = stack.pop();
                stack.push(a - b);
            } else if (c == '*') {
                int b = stack.pop();
                int a = stack.pop();
                stack.push(a * b);
            } else if (c == '/') {
                int b = stack.pop();
                int a = stack.pop();
                stack.push(a / b);
            } else {
                throw new IllegalArgumentException("Invalid postfix expression: unknown operator");
            }
        }

        if (stack.size() != 1) {
            throw new IllegalArgumentException("Invalid postfix expression: too few or too many operands");
        }

        return stack.pop();
    }

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        System.out.print("Enter an infix expression: ");
        String infix = scanner.nextLine();

        try {
            String postfix = infixToPostfix(infix);
            System.out.println("Postfix notation: " + postfix);
            int result = postfixEvaluation(postfix);
            System.out.println("Result: " + result);
        } catch (IllegalArgumentException e) {
            System.err.println("Error: " + e.getMessage());
        }
    }
}