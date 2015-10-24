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
        if (n > m){
            int temp = n;
            n = m;
            m = temp;
        }
        if (n != m){
            for (int i = 0; i <= m - n; i++) {
                Random rn = new Random();

                int rndNumber = n + rn.nextInt(m - n + 1);

                System.out.print(rndNumber + " ");

            }
        }else{
            System.out.println(n);
        }
    }
}
