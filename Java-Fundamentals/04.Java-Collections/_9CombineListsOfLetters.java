import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;
import java.util.Scanner;

public class _9CombineListsOfLetters {
    //Write a program that reads two lists of letters l1 and l2 and combines them:
    //appends all letters c from l2 to the end of l1, but only when c does not appear in l1.
    //Print the obtained combined list. All lists are given as sequence of letters
    //separated by a single space, each at a separate line.
    //Use ArrayList<Character> of chars to keep the input and output lists.

    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);

        ArrayList<Character> first = new ArrayList(Arrays.asList(console.nextLine().split("\\s+")));
        ArrayList<Character> second = new ArrayList(Arrays.asList(console.nextLine().split("\\s+")));
        for (int i = 0; i < second.size(); i++) {
            if(!first.contains(second.get(i))){
                first.add(second.get(i));
            }
        }
        for (int i = 0; i < first.size(); i++) {
            System.out.print(first.get(i) + " ");
        }

    }
}
