package com.company;

import java.util.Scanner;

public class _2TriangleArea {

    //Write a program that enters 3 points in the plane (as integer x and y coordinates),
    //calculates and prints the area of the triangle composed by these 3 points.
    //Round the result to a whole number.
    //In case the three points do not form a triangle, print "0" as result.

    //TO RUN THIS CLASS PRESS CTRL+SHIFT+F10
    //TO RUN THIS CLASS PRESS CTRL+SHIFT+F10
    //TO RUN THIS CLASS PRESS CTRL+SHIFT+F10
    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        int ax = console.nextInt();
        int ay = console.nextInt();
        int bx = console.nextInt();
        int by = console.nextInt();
        int cx = console.nextInt();
        int cy = console.nextInt();
        int triangleArea = (ax * (by - cy) + bx * (cy - ay) + cx * (ay - by)) / 2;
        System.out.println(Math.abs(triangleArea));
    }
}