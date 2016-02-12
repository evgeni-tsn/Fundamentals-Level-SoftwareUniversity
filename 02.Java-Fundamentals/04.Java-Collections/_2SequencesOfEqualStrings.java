import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

public class _2SequencesOfEqualStrings {
    //Write a program that enters an array of strings and finds in it all
    //sequences of equal elements.
    //The input strings are given as a single line, separated by a space.

    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        String[] input = console.nextLine().split(" ");

        for (int i = 0; i < input.length-1; i++) {
            System.out.print(input[i] + " ");
            if (!(input[i+1].equals(input[i])))
            {
                System.out.println();
        }
        }
        System.out.println(input[input.length-1]);
    }
}
