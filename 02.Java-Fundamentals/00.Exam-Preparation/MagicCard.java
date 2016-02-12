package Problem1;

import java.util.Arrays;
import java.util.Scanner;


public class MagicCard {

    public static void main(String[] args) {

        Scanner input = new Scanner(System.in);

        String[] cards = input.nextLine().split(" ");
        String[] values = {"*", "*", "2", "3", "4", "5", "6", "7", "8", "9",
                "10", "*", "J", "Q", "K", "A" };
        String oddEven = input.nextLine();
        String magicCard = input.nextLine();
        int sum = 0;

        String magicCardFace = magicCard.substring(0, magicCard.length() - 1);
        String magicCardSuit = magicCard.substring(magicCard.length() - 1, magicCard.length());
        int cardsCount = cards.length;
        int startPosition = oddEven.equals("odd") ? 1 : 0;

        for(int i = startPosition ; i < cardsCount ; i += 2) {

            String card = cards[i];
            String cardFace = card.substring(0, card.length() - 1);
            String cardSuit = card.substring(card.length() - 1, card.length());
            int value = Arrays.asList(values).indexOf(cardFace) * 10;

            if(cardFace.equals(magicCardFace)) {
                value *= 3;
            }
            else if(cardSuit.equals(magicCardSuit)) {
                value *= 2;
            }

            sum += value;
        }

        System.out.println(sum);

        input.close();
    }

}
