package com.company;

import java.util.*;

public class _7GhettoNumeralSystem {
    //Write a program that converts the decimal number system to the ghetto numeral system.
    //In the ghetto, numbers are represented as following:

    //TO RUN CLICK RIGHT BUTTON AND THEN RUN;
    //TO RUN CLICK RIGHT BUTTON AND THEN RUN;
    //TO RUN CLICK RIGHT BUTTON AND THEN RUN;

    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        int currentNum = console.nextInt();

        if (currentNum<0) currentNum=-currentNum;
        List<Integer> digits = new LinkedList<Integer>();

        while (currentNum>0) {
            digits.add(0, currentNum%10);
            currentNum=currentNum/10;
        }

        for (int digit : digits){
            switch (digit){
                case 0:
                    System.out.print("Gee");
                    break;
                case 1:
                    System.out.print("Bro");
                    break;
                case 2:
                    System.out.print("Zuz");
                    break;
                case 3:
                    System.out.print("Ma");
                    break;
                case 4:
                    System.out.print("Duh");
                    break;
                case 5:
                    System.out.print("Yo");
                    break;
                case 6:
                    System.out.print("Dis");
                    break;
                case 7:
                    System.out.print("Hood");
                    break;
                case 8:
                    System.out.print("Jam");
                    break;
                case 9:
                    System.out.print("Mack");
                    break;
            }
        }
    }
}
