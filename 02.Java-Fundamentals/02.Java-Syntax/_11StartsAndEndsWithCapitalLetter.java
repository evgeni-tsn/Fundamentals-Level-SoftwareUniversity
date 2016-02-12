package com.company;


import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class _11StartsAndEndsWithCapitalLetter {
    //Write a program that takes as input an array of strings are prints
    //only the words that start and end with capital letter.
    //Words are only strings that consist of English alphabet letters. Use regex.

    //TO RUN THIS CLASS PRESS CTRL+SHIFT+F10
    //TO RUN THIS CLASS PRESS CTRL+SHIFT+F10
    //TO RUN THIS CLASS PRESS CTRL+SHIFT+F10
    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        Pattern regex = Pattern.compile("\\b[A-Z][a-zA-Z]*[A-Z]\\b|\\b[A-Z]\\b");
        String input = console.nextLine();
        Matcher matcher = regex.matcher(input);
        while (matcher.find()) {
            System.out.print(matcher.group(0)+" ");
        }
    }
}
