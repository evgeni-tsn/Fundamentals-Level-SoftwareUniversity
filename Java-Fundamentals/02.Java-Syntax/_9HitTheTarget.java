package com.company;

import java.util.Scanner;

public class _9HitTheTarget {
    // Write a program that takes as input an integer – the target –
    // and outputs to the console all pairs of numbers between 1 and 20,
    // which, if added or subtracted, result in the target.
    public static void main(String[] args) {
        System.out.println("Enter you target: ");
        Scanner scanner = new Scanner(System.in);
        byte target = scanner.nextByte();
        hittingTheTarget(target);
    }

    private static void hittingTheTarget(byte target) {
        for (int i = 1; i <= 20 ; i++) {
            for (int j = 1; j <= 20; j++) {
                if(i + j == target) {
                    System.out.printf("%s + %s = %s\n", i, j, target);
                }
                if(i - j == target){
                    System.out.printf("%s - %s = %s\n", i, j, target);
                }
            }
        }
    }
}
