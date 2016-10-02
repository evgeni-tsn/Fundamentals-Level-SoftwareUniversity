package Problem4;

import java.util.*;
import java.util.stream.Collectors;

public class CouplesFrequency {
    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        HashMap<String, Integer>couples = new HashMap<>();
        List<String> inputList = Arrays.stream(console.nextLine().split(" "))
                .map(String::new)
                .collect(Collectors.toList());

        for (int i = 1; i < inputList.size(); i++) {
            String couple = inputList.get(i-1)+" "+(inputList.get(i));
            Integer count = couples.get(couple);
            if (count == null) {
                count = 0;
            }
            count++;
            couples.put(couple, count);
        }
        HashSet<String> printedCouples = new HashSet<>();
        for (int i = 1; i < inputList.size(); i++) {
            String couple = inputList.get(i-1)+" "+(inputList.get(i));

            if (!printedCouples.contains(couple)) {
                int count = couples.get(couple);
                float frequency = (float)count / (inputList.size()- 1);
                System.out.printf("%s -> %.2f%%\n", couple, frequency*100);
                printedCouples.add(couple);
            }
        }
    }
}
