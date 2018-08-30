package exercises;

import java.util.Scanner;

public class IntegerToHexAndBinary {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        Integer input = Integer.parseInt(scanner.nextLine());
        String hex = Integer.toHexString(input).toUpperCase();
        String binary = Integer.toBinaryString(input);

        System.out.println(hex);
        System.out.println(binary);
    }
}
