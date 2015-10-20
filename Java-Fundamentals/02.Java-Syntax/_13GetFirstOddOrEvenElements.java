package com.company;

import java.util.Scanner;

public class _13GetFirstOddOrEvenElements {
    //Write a method that returns the first N odd/even elements from a collection.
    //Return as many as you can.

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String[] elements = scanner.nextLine().split(" ");
        int remainder = 0;

        String[] commandArguments = scanner.nextLine().split(" ");
        switch (commandArguments[2]) {
            case "odd":
                remainder = 1;
                break;
            case "even":
                remainder = 0;
                break;
        }

        int count = 0;
        int elementIndex = 0;

        while (count < Integer.parseInt(commandArguments[1]) && elementIndex < elements.length) {
            int number = Integer.parseInt(elements[elementIndex]);
            if (number % 2 == remainder) {
                System.out.print(number + " ");
                count++;
            }

            elementIndex++;
        }
    }
}
