package Problem4;

import java.util.LinkedHashMap;
import java.util.Map;
import java.util.Scanner;
import java.util.TreeMap;

public class Weightifting {
    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        TreeMap<String, TreeMap<String, Long>> structure = new TreeMap<>();
        String line = "";
        int count = Integer.parseInt(console.nextLine());
        for (int i = 0; i < count; i++) {
            line = console.nextLine();
            String[] element = line.trim().split(" ");
            String player = element[0];
            String exercise = element[1];
            Long weight = Long.parseLong(element[2]);

            if (!structure.containsKey(player)) {
                structure.put(player, new TreeMap());
                structure.get(player).put(exercise, weight);
            } else {
                if (!structure.get(player).containsKey(exercise)) {
                    structure.get(player).put(exercise, weight);
                } else {
                    long oldWeight = structure.get(player).get(exercise);
                    structure.get(player).put(exercise, (weight + oldWeight));
                }
            }
        }
        for (String key : structure.keySet()) {
            String result = key + " : ";
            Map<String, Long> innerMap = structure.get(key);
            for (String innerKey : innerMap.keySet()) {
                result += String.format("%s - %d kg", innerKey, innerMap.get(innerKey));
                result += ", ";
            }
            System.out.println(result.substring(0, result.length() - 2));
        }


    }
}
