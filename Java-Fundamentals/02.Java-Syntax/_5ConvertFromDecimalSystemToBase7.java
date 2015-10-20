package com.company;

import java.util.Scanner;

public class _5ConvertFromDecimalSystemToBase7 {
    //Write a program that takes an integer number and converts it to base-7

    //TO RUN THIS CLASS PRESS CTRL+SHIFT+F10
    //TO RUN THIS CLASS PRESS CTRL+SHIFT+F10
    //TO RUN THIS CLASS PRESS CTRL+SHIFT+F10
    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        String num = console.next();
        String base7num = Integer.toString(Integer.parseInt(num, 10), 7);

        System.out.println(base7num);
    }
}
