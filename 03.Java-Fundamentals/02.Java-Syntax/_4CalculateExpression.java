package com.company;

import java.util.Scanner;

public class _4CalculateExpression {
    //Write a program that reads three floating point numbers from the console
    //and calculates their result with the following formulae:
    //((a2 + b2) / (a2 – b2))(a + b + c) / ?c             (a2 + b2 - c3)(a – b)

    //TO RUN THIS CLASS PRESS CTRL+SHIFT+F10
    //TO RUN THIS CLASS PRESS CTRL+SHIFT+F10
    //TO RUN THIS CLASS PRESS CTRL+SHIFT+F10
    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        double a = console.nextDouble();
        double b = console.nextDouble();
        double c = console.nextDouble();

        double firstExpression = Math.pow((Math.pow(a, 2) + Math.pow(b, 2)) / (Math.pow(a, 2) - Math.pow(b, 2)), ((a + b + c) / Math.sqrt(c)));

        double secondExpression = Math.pow((Math.pow(a,2)+Math.pow(b,2)-Math.pow(c,3)),a-b);

        double averageOfNums = (a+b+c)/3;
        double averageOfExpressions = (firstExpression+secondExpression)/2;

        double diff = Math.abs(averageOfNums-averageOfExpressions);
        System.out.println(String.format("F1 result: %.2f; F2 result: %.2f; Diff: %.2f",firstExpression,secondExpression,diff));
    }
}
