package Problem2;

import java.util.Scanner;

/**
 * Created by Evgeni on 11/1/2015.
 */
public class LettersChangeNumbers {
    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        String[] input = console.nextLine().split("\\s+");
        int getFirstValueFromAlphabet = 0;
        int getSecondValueFromAlphabet = 0;
        double formattingNum = 0;
        double totalSum =0 ;

        for (int i = 0; i < input.length; i++) {
            char firstLetter = input[i].charAt(0);
            char lastLetter = input[i].charAt(input[i].length()-1);
            String num = input[i].substring(1,input[i].length()-1);
            formattingNum = Integer.parseInt(num);
            boolean isFirstUpper = false;
            if (firstLetter>='A'&&firstLetter<='Z'){
                isFirstUpper = true;
            }
            if (firstLetter>='a'&&firstLetter<='z'){
                isFirstUpper = false;
            }
            if (isFirstUpper){
                getFirstValueFromAlphabet = firstLetter-'A'+1;
            }
            if (!isFirstUpper){
                getFirstValueFromAlphabet = firstLetter-'a'+1;
            }
            boolean isSecondUpper = false;
            if (lastLetter>='A'&&lastLetter<='Z'){
                isSecondUpper = true;
            }
            if (lastLetter>='a'&&lastLetter<='z'){
                isSecondUpper = false;
            }
            if (isSecondUpper){
                getSecondValueFromAlphabet = lastLetter-'A'+1;
            }
            if (!isSecondUpper){
                getSecondValueFromAlphabet = lastLetter-'a'+1;
            }
            if (isFirstUpper){
                formattingNum /= getFirstValueFromAlphabet;
            }
            if (!isFirstUpper){
                formattingNum *= getFirstValueFromAlphabet;
            }
            if (isSecondUpper){
                formattingNum -= getSecondValueFromAlphabet;
            }
            if (!isSecondUpper){
                formattingNum += getSecondValueFromAlphabet;
            }
            totalSum += formattingNum;
            formattingNum=0;
        }
        System.out.printf("%.2f",totalSum);
    }
}
