package com.company;

import java.util.Scanner;

public class _8GetAverage {
    //Create a method that finds the average of three numbers.
    //Read in internet about java methods.
    //Check the naming conventions.
    //Invoke your method and test it.
    //Format the output to two digits after the decimal separator.
    //The placeholder is %.2f

    //TO RUN CLICK RIGHT BUTTON AND THEN RUN;
    //TO RUN CLICK RIGHT BUTTON AND THEN RUN;
    //TO RUN CLICK RIGHT BUTTON AND THEN RUN;

    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        System.out.println("Enter count of numbers: ");
        int count = Integer.parseInt(console.nextLine());
        double[] nums = new double[count];
        System.out.println("Enter the numbers: ");
        for (int i = 0; i < nums.length; i++) {
            nums[i] = console.nextDouble();
        }

        System.out.println(String.format("%.2f",findAverage(nums)));
    }


    public static double findAverage(double[] nums){
        double total = 0;
        for (int i = 0; i < nums.length; i++) {
            total += nums[i];
        }
        double average = total/(double)nums.length;
        return average;
    }
}
