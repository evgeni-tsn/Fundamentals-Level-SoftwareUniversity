package Problem4;

import java.util.LinkedHashMap;
import java.util.Map;
import java.util.Scanner;
import java.util.TreeMap;

public class Orders {
    public static void main(String[] args) {
        LinkedHashMap<String, TreeMap<String, Long>> orders = new LinkedHashMap<>();
        Scanner console = new Scanner(System.in);
        Integer n = Integer.parseInt(console.nextLine());
        String line = "";
        for (int i = 0; i < n; i++) {
            line = console.nextLine();
            String[] splited = line.split(" ");
            String product = splited[2];
            Long amount = Long.parseLong(splited[1]);
            String customer = splited[0];
            if (!orders.containsKey(product)){
                orders.put(product, new TreeMap<>());
                orders.get(product).put(customer, amount);
            }else{
                if (!orders.get(product).containsKey(customer)){
                    orders.get(product).put(customer,amount);
                }
                else{
                    long oldAmount = orders.get(product).get(customer);
                    orders.get(product).put(customer, (amount + oldAmount));
                }
            }
        }
        for (String key : orders.keySet()) {
            String result = key + ": ";
            Map<String, Long> innerMap = orders.get(key);
            for (String innerKey : innerMap.keySet()) {
                result += String.format("%s %d", innerKey, innerMap.get(innerKey));
                result += ", ";
            }
            System.out.println(result.substring(0, result.length() - 2));
        }
    }
}
