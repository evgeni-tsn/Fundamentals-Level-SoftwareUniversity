package com.company;

import java.util.HashSet;
import java.util.Map;
import java.util.Random;
import java.util.Scanner;

public class _7RandomizeNumbersFromNtoM {
    //Write a program that takes as input two integers N and M,
    //and randomizes the numbers between them.
    //Note that M may be smaller than or equal to N.

    //TO RUN THIS CLASS PRESS CTRL+SHIFT+F10
    //TO RUN THIS CLASS PRESS CTRL+SHIFT+F10
    //TO RUN THIS CLASS PRESS CTRL+SHIFT+F10
    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        Random random = new Random();
        int n = console.nextInt();
        int m = console.nextInt();
        int low = n;
        int high = m;
        if (low>high){
            high=low;
        }
        int diff = Math.abs(n-m);
        for (int i = 0; i < diff+1; i++) {
            int r = (int) (Math.random() * (high - low)) + low;
            System.out.print(r + " ");
        }
        if (n==m){
            System.out.println(n);
        }
    }
}
