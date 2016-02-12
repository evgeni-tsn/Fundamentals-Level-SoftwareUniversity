import java.util.LinkedHashMap;
import java.util.Map;
import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class _12CardsFrequencies {
    //We are given a sequence of N playing cards from a standard deck.
    //The input consists of several cards (face + suit), separated by a space.
    //Write a program to calculate and print at the console the frequency of each
    //card face in format "card_face -> frequency". The frequency is calculated by
    //the formula appearances / N and is expressed in percentages with exactly 2 digits
    //after the decimal point. The card faces with their frequency should be printed in
    //the order of the card face's first appearance in the input.
    //The same card can appear multiple times in the input,
    //but it's face should be listed only once in the output.

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        System.out.print("Insert text with cards = ");
        String[] input = scanner.nextLine().trim().split(" ");
        int numOfAllCards = input.length;


        LinkedHashMap<String, Integer> res = new LinkedHashMap<>();
        for (int i = 0; i < input.length; i++) {
            String cardFace = input[i].substring(0, input[i].length() - 1);
            if(!res.containsKey(cardFace)) {
                res.put(cardFace, 0);
            }

            res.put(cardFace, res.get(cardFace) + 1);
        }

        for (Map.Entry<String, Integer> card : res.entrySet()) {
            double percentage = ((double)card.getValue() / numOfAllCards) * 100;
            System.out.printf("%s -> %.2f%%\n", card.getKey(), percentage);
        }
    }
}
