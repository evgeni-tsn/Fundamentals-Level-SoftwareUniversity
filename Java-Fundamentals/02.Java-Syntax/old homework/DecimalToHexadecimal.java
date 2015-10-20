package com.company;

import java.util.Scanner;

public class DecimalToHexadecimal {
    //Write a program that enters a positive integer number num and
    //converts and prints it in hexadecimal form.
    //You may use some built-in method from the standard Java libraries.

    //TO RUN THIS CLASS PRESS CTRL+SHIFT+F10
    //TO RUN THIS CLASS PRESS CTRL+SHIFT+F10
    //TO RUN THIS CLASS PRESS CTRL+SHIFT+F10
    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        int num = console.nextInt();

        String hex = Integer.toHexString(num).toUpperCase();

        System.out.println(hex);
    }
}
