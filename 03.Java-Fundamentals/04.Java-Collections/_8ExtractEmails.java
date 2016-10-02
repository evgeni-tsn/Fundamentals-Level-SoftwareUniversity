import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class _8ExtractEmails {
    //Write a program to extract all email addresses from given text.
    //The text comes at the first input line.
    //Print the emails in the output, each at a separate line.
    //Emails are considered to be in format <user>@<host>

    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        String input = console.nextLine();

        Pattern regex = Pattern.compile("(?<=\\s|^)([a-z0-9]+(?:[_.-][a-z0-9]+)*@(?:[a-z]+\\-?[a-z]+\\.)+[a-z]+\\-?[a-z]+)\\b");
        Matcher mailMatcher = regex.matcher(input.toLowerCase());
        while (mailMatcher.find()){
            System.out.println(mailMatcher.group(1));
        }
    }
}
