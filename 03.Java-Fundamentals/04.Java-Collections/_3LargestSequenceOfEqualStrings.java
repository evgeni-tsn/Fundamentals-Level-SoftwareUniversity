import java.util.Scanner;

public class _3LargestSequenceOfEqualStrings {
    //Write a program that enters an array of strings and finds in it the largest sequence of equal elements.
    //If several sequences have the same longest length,
    //print the leftmost of them. The input strings are given as a single line, separated by a space.

    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        String[] input = console.nextLine().trim().split(" ");

        int startIndex = 0;
        int longestSeq = 1;

        for (int i = 0; i < input.length; i++) {
            String currStr = input[i];
            int currLongestSeq = 1;
            int currStartIndex = i;
            for (int j = i+1; j < input.length; j++) {
                String compareStr = input[j];
                if (compareStr.equals(currStr)) {
                    currLongestSeq++;
                    i++;
                } else {
                    break;
                }
            }
            if (currLongestSeq > longestSeq){
                longestSeq = currLongestSeq;
                startIndex = currStartIndex;
            }
        }

        System.out.printf("The longest sequence is: %s", input[startIndex]);
        for (int i = startIndex+1; i < startIndex+longestSeq; i++) {
            System.out.print(" "+ input[i]);
        }
    }
}
