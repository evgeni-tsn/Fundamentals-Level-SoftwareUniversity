package com.company;

import java.util.ArrayList;
import java.util.Collections;
import java.util.List;
import java.util.Scanner;

public class TheSmallestOf3Numbers {

    //Write a program that finds the smallest of three numbers.

    //TO RUN THIS CLASS PRESS CTRL+SHIFT+F10
    //TO RUN THIS CLASS PRESS CTRL+SHIFT+F10
    //TO RUN THIS CLASS PRESS CTRL+SHIFT+F10
    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        ArrayList<Double> nums = new ArrayList<Double>();
        for (int i = 0; i < 3; i++) {
            nums.add(console.nextDouble());
        }
        double minIndex = Collections.min(nums);
        System.out.println(minIndex);
    }
}
