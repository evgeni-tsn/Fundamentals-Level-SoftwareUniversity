package com.company;

import java.util.Scanner;

public class PrintCharacterTriangle {
    //Create a triangle of characters, based on input.
    //Learn about java.util.Scanner and Integer.parseInt ().
    //Test your program with integers up to 26. Think why.

    //TO RUN CLICK RIGHT BUTTON AND THEN RUN PrintCharacterTriangle..main();
    //TO RUN CLICK RIGHT BUTTON AND THEN RUN PrintCharacterTriangle..main();
    //TO RUN CLICK RIGHT BUTTON AND THEN RUN PrintCharacterTriangle..main();

    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        int count = console.nextInt();

        for (int i = 0; i < count; i++) {
            for (int j = 0; j < i; j++) {
                System.out.print((char) (j + 97) + " ");
            }
            System.out.println();
        }
        for (int i = count; i > 0; i--) {
            for (int j = 0; j < i; j++) {
                System.out.print((char) (j + 97) + " ");
            }
            System.out.println();
        }
    }
}
