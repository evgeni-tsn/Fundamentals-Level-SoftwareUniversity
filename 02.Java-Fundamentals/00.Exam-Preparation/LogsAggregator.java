package Problem4;

import java.util.*;

public class LogsAggregator {
    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        TreeMap<String, Integer> durations = new TreeMap<>();
        HashMap<String, TreeSet<String>> ipAddresses = new HashMap<>();
        int n = Integer.parseInt(console.nextLine());
        String line = "";
        for (int i = 0; i < n; i++) {
            line = console.nextLine();
            String[] part = line.split(" ");
            String ip = part[0];
            String user = part[1];
            int duration = Integer.parseInt(part[2]);

            Integer oldDuration = durations.get(user);
            if (oldDuration == null) {
                oldDuration = 0;
            }
            durations.put(user, oldDuration + duration);

            TreeSet<String> ipSet = ipAddresses.get(user);
            if (ipSet == null) {
                ipSet = new TreeSet<>();
            }
            ipSet.add(ip);
            ipAddresses.put(user, ipSet);
        }

        for (Map.Entry<String, Integer> entry : durations.entrySet()) {
            String user = entry.getKey();
            int duration = entry.getValue();
            TreeSet<String> ipSet = ipAddresses.get(user);
            System.out.println(user + ": " + duration + " " + ipSet);
        }
    }
}
