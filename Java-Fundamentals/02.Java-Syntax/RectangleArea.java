package com.company;

import java.util.Scanner;

public class RectangleArea {
    //Write a program that enters the sides of a rectangle (two integers a and b)
    //and calculates and prints the rectangle's area.

    //TO RUN THIS CLASS PRESS CTRL+SHIFT+F10
    //TO RUN THIS CLASS PRESS CTRL+SHIFT+F10
    //TO RUN THIS CLASS PRESS CTRL+SHIFT+F10
    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        double a = console.nextDouble();
        double b = console.nextDouble();

        double rectangleArea = a*b;

        System.out.println(rectangleArea);
    }
}
