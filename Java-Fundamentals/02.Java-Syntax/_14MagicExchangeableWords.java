package com.company;

import java.util.HashMap;
import java.util.Scanner;

public class _14MagicExchangeableWords {
    //Write a method that takes as input two strings of equal length, and returns Boolean if they are exchangeable or not.
    //Exchangeable are words where the characters in the first string can be replaced to get the second string.
    //Example: egg and add are exchangeable, but aabbccbb and nnooppzz are not.
    //(First bb corresponds to oo, but second bb corresponds to zz)

    public static void main(String[] args) {
        System.out.println("Enter the two strings: ");
        Scanner scanner = new Scanner(System.in);
        String firstString = scanner.next();
        String secondString = scanner.next();
        boolean theStringsAreExchangeable = areTheStringExchangeable(firstString, secondString);
        System.out.println(theStringsAreExchangeable);
    }

    private static boolean areTheStringExchangeable(String firstString, String secondString) {
        HashMap<Character, Character> exchangeability = new HashMap<>();
        if(firstString.length() == secondString.length()) {
            for (int i = 0; i < firstString.length(); i++) {
                if(exchangeability.containsKey(firstString.charAt(i))){
                    if(secondString.charAt(i) != exchangeability.get(firstString.charAt(i))){
                        return false;
                    }
                } else if(exchangeability.containsValue(secondString.charAt(i))){
                    return false;
                } else {
                    exchangeability.put(firstString.charAt(i), secondString.charAt(i));
                }

                            }
        } else {
            System.out.println("The strings must be with equal length...");
            System.exit(0);
        }
        return true;

    }
}
