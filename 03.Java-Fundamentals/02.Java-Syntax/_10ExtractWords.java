package com.company;

import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class _10ExtractWords {
    //Write a program that extracts words from a string.
    //Words are sequences of characters that are at least two symbols
    //long and consist only of English alphabet letters. Use regex.

    //TO RUN THIS CLASS PRESS CTRL+SHIFT+F10
    //TO RUN THIS CLASS PRESS CTRL+SHIFT+F10
    //TO RUN THIS CLASS PRESS CTRL+SHIFT+F10
    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        String  input = console.nextLine();
        Pattern wordPattern = Pattern.compile(
                "[A-Za-z]+");
        Matcher matcher = wordPattern.matcher(input);
        while (matcher.find()) {
            System.out.print(matcher.group()+" ");
        }

    }
}
