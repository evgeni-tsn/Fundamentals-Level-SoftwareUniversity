package com.company;

import java.util.Scanner;

public class _12CharacterMultiplier {
    //Create a method that takes two strings as arguments and returns the sum of their character codes
    // multiplied (multiply str1.charAt (0) with str2.charAt (0) and add to the total sum).
    // Then continue with the next two characters.
    // If one of the strings is longer than the other, add the remaining character codes to the total sum without multiplication.

    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        String firstStr = console.next();
        String secondStr = console.next();
        System.out.println(CharMultiplier(firstStr, secondStr));
    }

    public static int CharMultiplier(String first, String second){
        int totalSum = 0;
        int charDiff;
        String diffStr = "";
        if (first.length()>second.length()){
            charDiff = first.length()-second.length();
            diffStr = first.substring(first.length()-charDiff, first.length());
        }
        else if(first.length()<second.length()){
            charDiff = second.length()-first.length();
            diffStr = second.substring(second.length()-charDiff, second.length());
        }
        for (int i = 0; i < Math.min(first.length(),second.length()); i++) {
              totalSum += (int)first.charAt(i)*(int)second.charAt(i);
        }
        for (int i = 0; i < diffStr.length(); i++) {
            totalSum+=(int)diffStr.charAt(i);
        }
        return totalSum;
    }
}
