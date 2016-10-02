package Problem4;

import java.util.*;

public class LegendaryFarming {

    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        LinkedHashMap<String, Integer> keyMaterials = new LinkedHashMap<String, Integer>() {{
            put("fragments", 0);
            put("motes", 0);
            put("shards", 0);
        }};

        TreeMap<String, Integer> junk = new TreeMap<>();
        String keyMaterialCollectedFirst = "";

        while (true){
            String[] items = console.nextLine().split(" ");
            for (int i = 0; i < items.length; i+= 2) {
                int quantity = Integer.parseInt(items[i]);
                String item = items[i+1].toLowerCase();

                if (keyMaterials.containsKey(item)){
                    keyMaterials.put(item, keyMaterials.get(item)+quantity);

                    if (keyMaterials.get(item) >= 250){
                        keyMaterials.put(item, keyMaterials.get(item) - 250);
                        keyMaterialCollectedFirst = item;
                        break;
                    }
                }else{
                    if (!junk.containsKey(item)){
                        junk.put(item,0);
                    }
                    junk.put(item, junk.get(item) + quantity);
                }
            }
            if (keyMaterialCollectedFirst.length()>0){
                break;
            }
        }
        System.out.println(getLeg(keyMaterialCollectedFirst) + " obtained!");

        keyMaterials
                .entrySet()
                .stream()
                .sorted((k1, k2) -> k2.getValue().compareTo(k1.getValue()))
                .forEach(k -> System.out.println(k.getKey()+": "+k.getValue()));

        junk.entrySet().forEach(j-> System.out.println(j.getKey()+ ": "+j.getValue()));
    }
    public static String getLeg(String material){
        if (material.equals("shards")) return "Shadowmourne";
        if (material.equals("fragments")) return "Valanyr";

        return "Dragonwrath";
    }
}
