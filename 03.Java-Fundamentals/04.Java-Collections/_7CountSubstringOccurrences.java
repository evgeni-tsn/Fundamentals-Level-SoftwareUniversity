import java.util.Scanner;

public class _7CountSubstringOccurrences {
    //Write a program to find how many times given string appears in given text as substring.
    //The text is given at the first input line.
    //The search string is given at the second input line.
    //The output is an integer number.
    //Please ignore the character casing.

    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        String input = console.nextLine().toLowerCase();
        String keyWord = console.next().toLowerCase();

        int index = 0;
        int counter = 0;

        while (true){
            int currMatch = input.indexOf(keyWord,index);
            if (currMatch<0){
                break;
            }
            counter++;
            index = currMatch+1;
        }

        System.out.println(counter);


    }
}
