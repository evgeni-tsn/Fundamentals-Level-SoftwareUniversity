package com.company;

import java.util.Scanner;

public class CountOfEqualBitPairs {

    //Write a program to count how many sequences of two equal bits ("00" or "11")
    //can be found in the binary representation of given integer number n (with overlapping).

    //TO RUN THIS CLASS PRESS CTRL+SHIFT+F10
    //TO RUN THIS CLASS PRESS CTRL+SHIFT+F10
    //TO RUN THIS CLASS PRESS CTRL+SHIFT+F10
    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        long num = console.nextLong();

        String binaryNum =  Long.toBinaryString(num);
        char[] bits = binaryNum.toCharArray();
        int counter = 0;
        for (int i = 1; i < bits.length; i++) {
            if (bits[i-1]=='1' && bits[i]=='1'){
                counter++;
            }
            else if  (bits[i-1]=='0' && bits[i]=='0'){
                counter++;
            }
        }
        System.out.println(counter);
    }
}
