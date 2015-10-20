package com.company;

import java.util.Scanner;

public class PointsInsideAFigure {
    //Write a program to check whether a point is inside or outside of the figure below.
    //The point is given as a pair of floating-point numbers, separated by a space.
    //Your program should print "Inside" or "Outside".

    //TO RUN THIS CLASS PRESS CTRL+SHIFT+F10
    //TO RUN THIS CLASS PRESS CTRL+SHIFT+F10
    //TO RUN THIS CLASS PRESS CTRL+SHIFT+F10
    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);

        while (true){
            double x = console.nextDouble();
            double y = console.nextDouble();

            if (InsideLongRect(x,y)||InsideShortRect(x,y)||InsideSqaure(x,y)){
                System.out.println("Inside");
            }
            else {
                System.out.println("Outside");
            }
        }
    }
    public static boolean InsideLongRect (double x, double y){
        boolean isInside = false;
        if ((x>=12.5&&x<=22.5)&&(y>=6&&y<=8.5)){
            isInside = true;
        }
        return isInside;
    }
    public static boolean InsideShortRect (double x, double y){
        boolean isInside = false;
        if ((x>=20&&x<=22.5)&&(y>=8.5&&y<=13.5)){
            isInside = true;
        }
        return isInside;
    }
    public static boolean InsideSqaure (double x, double y){
        boolean isInside = false;
        if ((x>=12.5&&x<=17.5)&&(y>=8.5&&y<=13.5)){
            isInside = true;
        }
        return isInside;
    }

}
