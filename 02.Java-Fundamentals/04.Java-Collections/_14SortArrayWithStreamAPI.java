import java.util.*;

public class _14SortArrayWithStreamAPI {
    //Use the .sorted() method to sort an array of integers.
    //The first line of input is the array. The second is the sorting order.

    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        ArrayList<String> stringsList = new ArrayList<>(Arrays.asList(console.nextLine().split("\\s+")));
        String order = console.nextLine();

        if (order.equals("Ascending")){
            stringsList.stream()
                    .sorted((num1, num2) -> num1.compareTo(num2))
                    .forEach(num -> System.out.print(num + " "));
        } else{
            stringsList.stream()
                    .sorted((num1, num2) -> num2.compareTo(num1))
                    .forEach(num -> System.out.print(num + " "));
        }
    }
}
