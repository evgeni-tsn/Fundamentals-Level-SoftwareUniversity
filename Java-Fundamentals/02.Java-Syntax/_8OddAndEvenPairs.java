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
        System.out.print("Enter the size of array (even num): ");
        int sizeOfArray = console.nextInt();
        if (sizeOfArray%2==1){
            System.out.println("Invalid lenght");
            return;
        }
        int[] array = new int[sizeOfArray];
        System.out.printf("Enter %d elements with space between: ",sizeOfArray);
        for (int i = 0; i < array.length; i++) {
            array[i] = console.nextInt();
        }

        for (int i = 1; i < array.length; i+=2) {
            if ((array[i-1]%2==0)&&(array[i]%2==0)){
                System.out.printf("%d, %d -> both are even\n",array[i-1], array[i]);
            }
            else if ((array[i-1]%2==1)&&(array[i]%2==1)){
                System.out.printf("%d, %d -> both are odd\n", array[i - 1], array[i]);
            }
            else{
                System.out.printf("%d, %d -> different\n",array[i-1], array[i]);
            }
        }
    }
}
