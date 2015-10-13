package com.company;

import java.util.Scanner;

public class PointsInsideTheHouse {
    //Write a program to check whether a point is inside or outside the house below.
    //The point is given as a pair of floating-point numbers, separated by a space.
    //Your program should print "Inside" or "Outside".

    //TO RUN THIS CLASS PRESS CTRL+SHIFT+F10
    //TO RUN THIS CLASS PRESS CTRL+SHIFT+F10
    //TO RUN THIS CLASS PRESS CTRL+SHIFT+F10
    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);

        while (true) {
            double x = console.nextDouble();
            double y = console.nextDouble();

            if (InsideTriangle(x, y) || InsideShortRect(x, y) || InsideSqaure(x, y)) {
                System.out.println("Inside");
            } else {
                System.out.println("Outside");
            }
        }
    }

    public static boolean InsideTriangle(double x, double y) {
        boolean isInside = false;
        if ((x >= 12.5 && x <= 22.5) && (y >= 6 && y <= 8.5)) {
            isInside = true;
        }
        return isInside;
    }

    public static boolean InsideShortRect(double x, double y) {
        boolean isInside = false;
        if ((x >= 20 && x <= 22.5) && (y >= 8.5 && y <= 13.5)) {
            isInside = true;
        }
        return isInside;
    }

    public static boolean InsideSqaure(double x, double y) {
        boolean isInside = false;
        if ((x >= 12.5 && x <= 17.5) && (y >= 8.5 && y <= 13.5)) {
            isInside = true;
        }
        return isInside;
    }
    public static boolean insideTriangle(double X, double Y) {
        double areaABC = getTriangleArea(12.5, 8.5, 22.5, 8.5, 17.5, 3.5);
        double areaAPB = getTriangleArea(12.5, 8.5, X, Y, 22.5, 8.5);
        double areaBPC = getTriangleArea(22.5, 8.5, X, Y, 17.5, 3.5);
        double areaCPA = getTriangleArea(17.5, 3.5, X, Y, 12.5, 8.5);

        if (areaABC == areaAPB + areaBPC + areaCPA) {
            return true;
        } else {
            return false;
        }
    }
    public static double getTriangleArea(double Ax, double Ay, double Bx, double By, double Cx, double Cy) {
        double area = 0;
        area += Ax*(By - Cy);
        area += Bx*(Cy - Ay);
        area += Cx*(Ay - By);
        area /= 2.0;
        area = Math.abs(area);

        return area;
    }
}
