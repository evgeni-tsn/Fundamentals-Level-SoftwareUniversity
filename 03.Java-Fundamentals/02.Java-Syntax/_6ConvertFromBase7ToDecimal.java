package com.company;

import java.util.Scanner;

public class _6ConvertFromBase7ToDecimal {
    //Write a program that converts from a base-7 number to its decimal representation

    //TO RUN THIS CLASS PRESS CTRL+SHIFT+F10
    //TO RUN THIS CLASS PRESS CTRL+SHIFT+F10
    //TO RUN THIS CLASS PRESS CTRL+SHIFT+F10
    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        String num = console.next();
        String base7toDecimal = Integer.toString(Integer.parseInt(num, 7), 10);

        System.out.println(base7toDecimal);
    }
}
