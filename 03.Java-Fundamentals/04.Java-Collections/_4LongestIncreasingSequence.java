import java.util.Scanner;

public class _4LongestIncreasingSequence {
    //Write a program to find all increasing sequences inside an array of integers.
    //The integers are given in a single line, separated by a space.
    //Print the sequences in the order of their appearance in the input array, each at a single line.
    //Separate the sequence elements by a space. Find also the longest increasing sequence and print it at the last line.
    //If several sequences have the same longest length, print the leftmost of them.

    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);

        String[] inputArr = console.nextLine().trim().split(" ");
        int[] nums = new int[inputArr.length];
        for (int i = 0; i < nums.length; i++) {
            nums[i] = Integer.parseInt(inputArr[i]);
        }

        int longestSequence = 0;
        int startIndex = 0;
        for (int i = 0; i < nums.length; i++) {
            int currentNum = nums[i];
            int currentIndex = i;
            int currentLongestSequence = 1;
            System.out.print(currentNum);

            for (int j = i + 1; j < nums.length; j++) {
                int subNum = nums[j];
                if (subNum > currentNum) {
                    System.out.print(" " + subNum);
                    currentNum = subNum;
                    currentLongestSequence++;
                    i++;
                } else {
                    break;
                }
            }

            if(currentLongestSequence > longestSequence) {
                longestSequence = currentLongestSequence;
                startIndex = currentIndex;
            }

            System.out.println();
        }

        System.out.print("Longest:");
        for (int i = startIndex; i < startIndex + longestSequence; i++) {
            System.out.print(" " + nums[i]);
        }
    }
}
