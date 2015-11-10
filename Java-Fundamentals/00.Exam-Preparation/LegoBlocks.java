package Problem3;

import java.util.*;
import java.util.stream.Collectors;

/**
 * Created by Evgeni on 11/1/2015.
 */
public class LegoBlocks {
    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        int maxLenght = 0;
        int totalSum = 0;
                List<List<String>> firstInput = new ArrayList<>();
        Integer rows = Integer.parseInt(console.nextLine());
        for (int i = 0; i < rows; i++) {
           firstInput.add(Arrays.stream(console.nextLine().trim().split("\\s+")).collect(Collectors.toList()));
        }
        List<List<String>> secondInput = new ArrayList<>();
        for (int i = 0; i < rows; i++) {
            secondInput.add(Arrays.stream(console.nextLine().trim().split("\\s+")).collect(Collectors.toList()));
        }
        for (int i = 0; i < firstInput.size(); i++) {
            totalSum+=firstInput.get(i).size()+secondInput.get(i).size();
            if (firstInput.get(i).size() + secondInput.get(i).size()>maxLenght){
                maxLenght = firstInput.get(i).size() + secondInput.get(i).size();
            }

        }
        for (int i = 0; i < firstInput.size() ; i++) {

            if (firstInput.get(i).size()+secondInput.get(i).size()!=maxLenght) {
                System.out.println("The total number of cells is: " + totalSum);
                break;
            }else if(firstInput.get(i).size()+secondInput.get(i).size()==maxLenght){
                Collections.reverse(secondInput.get(i));
                StringBuilder sb = new StringBuilder();
                sb.append("[");
                for (String s : firstInput.get(i))
                {
                    sb.append(s);
                    sb.append(", ");
                }
                for (String s : secondInput.get(i))
                {
                    sb.append(s);
                    sb.append(", ");
                }
                sb.append("]");
                String tempStr = sb.toString();
                String finall = tempStr.substring(0,tempStr.length()-3)+"]";
                System.out.println(finall);
            }
        }
    }
}
