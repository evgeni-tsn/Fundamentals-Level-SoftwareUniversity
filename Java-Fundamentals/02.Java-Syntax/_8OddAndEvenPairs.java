package com.company;

import java.util.Scanner;

public class _8OddAndEvenPairs {
    //You are given an array of integers as a single line, separated by a space.
    //Write a program that checks consecutive pairs and prints if both are odd/even or not.
    //Note that the array length should also be an even number

    //TO RUN THIS CLASS PRESS CTRL+SHIFT+F10
    //TO RUN THIS CLASS PRESS CTRL+SHIFT+F10
    //TO RUN THIS CLASS PRESS CTRL+SHIFT+F10
    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);

        String[] inputArray = console.nextLine().split(" ");
        if (inputArray.length%2!=0){
            System.out.println("Invalid lenght");
        }else {
            for (int i = 0; i < inputArray.length; i += 2) {
                int firstNum = Integer.parseInt(inputArray[i]);
                int secondNum = Integer.parseInt(inputArray[i + 1]);

                String str = "different";
                if (firstNum % 2 ==0 && secondNum % 2 == 0) {
                    str = "both are even";
                } else if (firstNum % 2 != 0 && secondNum % 2 != 0) {
                    str = "both are odd";
                }
                System.out.format("%d, %d -> %s", firstNum, secondNum, str);
                System.out.println();
            }
    }
}
}
