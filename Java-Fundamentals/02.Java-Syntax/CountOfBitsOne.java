package com.company;

import java.util.Scanner;

public class CountOfBitsOne {
    //Write a program to calculate the count of bits 1 in the
    //binary representation of given integer number n.

    //TO RUN THIS CLASS PRESS CTRL+SHIFT+F10
    //TO RUN THIS CLASS PRESS CTRL+SHIFT+F10
    //TO RUN THIS CLASS PRESS CTRL+SHIFT+F10
    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        long num = console.nextLong();

        String binaryNum =  Long.toBinaryString(num);
        char[] bits = binaryNum.toCharArray();
        int counter = 0;
        for (int i = 0; i < bits.length; i++) {
            if (bits[i]=='1'){
                counter++;
            }
        }
        System.out.println(counter);
    }
}
