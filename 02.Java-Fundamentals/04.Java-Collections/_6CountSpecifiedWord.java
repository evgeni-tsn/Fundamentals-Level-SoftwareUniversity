import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class _6CountSpecifiedWord {
    //Write a program to find how many times a word appears in given text.
    //The text is given at the first input line. The target word is given at the second input line.
    //The output is an integer number. Please ignore the character casing.
    //Consider that any non-letter character is a word separator.

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String input = scanner.nextLine();
        String keyWord = scanner.nextLine();
        StringBuilder currentWord=new StringBuilder();
        int wordCounter=0;
        for(int i=0;i<input.length();i++){
            if(Character.isAlphabetic(input.charAt(i))){
                currentWord.append(input.charAt(i));
            }else{
                if(keyWord.equals(currentWord.toString())){
                    wordCounter++;
                }
                currentWord=new StringBuilder();
            }
        }
        System.out.print(wordCounter);
    }
}
