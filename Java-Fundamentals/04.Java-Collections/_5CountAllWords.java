import java.util.Scanner;

public class _5CountAllWords {
    //Write a program to count the number of words in given sentence.
    //Use any non-letter character as word separator.

    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        String[] input = console.nextLine().trim().split("\\w+");
        System.out.println(input.length-1);
    }
}
