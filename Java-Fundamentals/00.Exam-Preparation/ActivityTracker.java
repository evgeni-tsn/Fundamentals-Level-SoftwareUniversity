package Problem4;

import java.util.Map;
import java.util.Scanner;
import java.util.TreeMap;

public class ActivityTracker {
    public static void main(String[] args) {
        TreeMap<Long, TreeMap<String, Long>>tracker = new TreeMap<>();
        Scanner console = new Scanner(System.in);
        Integer n = Integer.parseInt(console.nextLine());
        String line = "";
        for (int i = 0; i < n; i++) {
            line = console.nextLine();
            String[] element = line.split(" ");
            Long month = Long.parseLong(element[0].substring(3,5));
            String name = element[1];
            Long distance = Long.parseLong(element[2]);

            if (!tracker.containsKey(month)){
                tracker.put(month, new TreeMap<>());
                tracker.get(month).put(name, distance);
            }else{
                if (!tracker.get(month).containsKey(name)){
                    tracker.get(month).put(name,distance);
                }
                else{
                    long oldDistance = tracker.get(month).get(name);
                    tracker.get(month).put(name, (distance + oldDistance));
                }
            }
        }
        for (Long key : tracker.keySet()) {
            String result = key + ": ";
            Map<String, Long> innerMap = tracker.get(key);
            for (String innerKey : innerMap.keySet()) {
                result += String.format("%s(%d)", innerKey, innerMap.get(innerKey));
                result += ", ";
            }
            System.out.println(result.substring(0, result.length() - 2));
        }
    }
}
