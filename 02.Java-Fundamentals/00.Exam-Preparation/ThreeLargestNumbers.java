package Problem1;

import java.math.BigDecimal;
import java.util.ArrayList;
import java.util.Collections;
import java.util.List;
import java.util.Scanner;

/**
 * Created by Evgeni on 11/2/2015.
 */
public class ThreeLargestNumbers {
    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        Integer n = Integer.parseInt(console.nextLine());
        List<BigDecimal> numbers = new ArrayList<>();
        for (int i = 0; i < n; i++) {
            numbers.add(new BigDecimal(console.nextLine()));
        }
        Collections.sort(numbers);
        Collections.reverse(numbers);
        if (numbers.size()==2){
            System.out.println(numbers.get(0));
            System.out.println(numbers.get(1));
        }else if (numbers.size()==1){
            System.out.println(numbers.get(0));
        }else if (numbers.size()==3){
            System.out.println(numbers.get(0));
            System.out.println(numbers.get(1));
            System.out.println(numbers.get(2));
        }else{
            for (int i = 0; i < 3; i++) {
                System.out.println(numbers.get(i));
            }
        }
    }
}
