package Problem4;

import java.util.LinkedHashMap;
import java.util.Scanner;
import java.util.TreeMap;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

/**
 * Created by Evgeni on 11/1/2015.
 */
public class UserLogs {
    public static void main(String[] args) {
        //
        Scanner console = new Scanner(System.in);
        TreeMap<String, LinkedHashMap<String, Integer>> logs = new TreeMap<>();
        String line = console.nextLine();
        while(!line.equals("end")){
            Pattern regex = Pattern.compile("IP=(\\S+).+user=(.+)");
            Matcher m = regex.matcher(line);
            if (m.matches()){
                String username = m.group(2);
                String ip = m.group(1);
                if (!logs.containsKey(username)){
                    logs.put(username, new LinkedHashMap<>());
                    logs.get(username).put(ip, 1);
                }else{
                    if (!logs.get(username).containsKey(ip)){
                        logs.get(username).put(ip,1);
                    }
                    else{
                        logs.get(username).put(ip, logs.get(username).get(ip)+1);
                    }
                }
            }
            line = console.nextLine();
        }
        for (String user : logs.keySet()) {
            System.out.println(user+": ");
            String output = "";
            for (String ip : logs.get(user).keySet()) {
                output += String.format(" "+ip + " => " + logs.get(user).get(ip) + ",");
            }
            System.out.println(output.substring(0, output.length()-1)+".");
        }
    }
}
