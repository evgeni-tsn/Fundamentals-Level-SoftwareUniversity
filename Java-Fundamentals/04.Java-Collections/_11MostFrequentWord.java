import java.util.*;

public class _11MostFrequentWord {
//Write a program to find the most frequent word in a text and print it,
//as well as how many times it appears in format "word -> count".
//Consider any non-letter character as a word separator.
//Ignore the character casing.
//If several words have the same maximal frequency, print all of them in alphabetical order.

    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        String str1 = console.nextLine().toLowerCase();

        String[] words;
        Map<String, Integer> wordsCount = new TreeMap<String, Integer>();
        words = str1.split("[\\W]+");
        for (String word : words) {
            Integer count = wordsCount.get(word);
            if (count == null) {
                count = 0;
            }
            wordsCount.put(word, count+1);
        }

        Integer maxLength = wordsCount.values().stream().max(Integer::compare).get();

        for(String key : wordsCount.keySet()){
            if(wordsCount.get(key) == maxLength){
                System.out.printf("%s -> %d times%n",key,maxLength);
            }
        }
    }
}
