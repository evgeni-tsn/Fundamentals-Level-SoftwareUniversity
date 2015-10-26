import java.util.Arrays;
import java.util.Scanner;

public class _1SortArrayOfNumbers {
    //Write a program to enter a number n and n integer numbers and
    //sort and print them. Keep the numbers in array of integers: int[].

    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        System.out.println("Enter the array lenght");
        int inputLenght = Integer.parseInt(console.nextLine());
        int[] mainArray = new int[inputLenght];
        for (int i = 0; i < mainArray.length; i++) {
            mainArray[i] = console.nextInt();
        }
        Arrays.sort(mainArray);
        for (int i : mainArray) {
            System.out.print(i+" ");
        }

    }
}
