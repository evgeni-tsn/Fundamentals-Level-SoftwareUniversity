import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

public class _13FilterArray {
//Write a program that filters an array of strings,
//leaving only the strings with length greater than 3 characters.
//Use .filter()

    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        String[] element = console.nextLine().split("[\\W]+");
        List<String> input = new ArrayList<>();
        for (String s : element) {
            input.add(s);
        }
        input.stream().filter(x -> x.length() > 3).forEach(e -> System.out.print(e + " "));

    }
}
