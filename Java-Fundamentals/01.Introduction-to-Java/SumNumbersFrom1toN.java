package com.company;

import java.util.Scanner;

public class SumNumbersFrom1toN {
    //Create a Java program that reads a number N from the console
    //and calculates the sum of all numbers from 1 to N (inclusive).

    //TO RUN CLICK RIGHT BUTTON AND THEN RUN SumNumbersFrom1toN..main();
    //TO RUN CLICK RIGHT BUTTON AND THEN RUN SumNumbersFrom1toN..main();
    //TO RUN CLICK RIGHT BUTTON AND THEN RUN SumNumbersFrom1toN..main();

    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        int n = console.nextInt();
        int sum = 0 ;
        int counter = 0;
        while (n>=counter){
            sum +=counter;
            counter++;
        }
        System.out.println(sum);
    }
}
