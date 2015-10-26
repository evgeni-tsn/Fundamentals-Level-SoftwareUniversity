import java.util.HashSet;
import java.util.Scanner;
import java.util.SortedSet;
import java.util.TreeSet;

public class _10ExtractAllUniqueWords {
//At the first line at the console you are given a piece of text.
//Extract all words from it and print them in alphabetical order.
//Consider each non-letter character as word separator.
//Take the repeating words only once. Ignore the character casing.
//Print the result words in a single line, separated by spaces.

    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        String str1 = console.nextLine().toLowerCase();
        //.split("[\\W]+")
        String[] words;
        TreeSet<String> uniqueWords = new TreeSet<String>();
        words = str1.split("[\\W]+");
        for (int i = 0; i < words.length; i++)
        {
            uniqueWords.add(words[i]);
        }
        System.out.println(uniqueWords);
    }
}
