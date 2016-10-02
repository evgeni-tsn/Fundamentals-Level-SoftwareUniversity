package Problem2;

import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class WeirdScript {

    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        StringBuilder sb = new StringBuilder();
        int key = Integer.parseInt(console.nextLine());
        boolean isUpper = true;
        if ((key/26)%2==0){
            isUpper=false;
        }
        Character[] letters = new Character[]
                {'z','a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y'};
        String getKey = letters[key%26].toString();
        String formattedKey = getKey+getKey;
        if (isUpper){
            formattedKey = formattedKey.toUpperCase();
        }else {
            formattedKey = formattedKey.toLowerCase();
        }

        String line = console.nextLine();
        while (!(line.equals("End"))){
            sb.append(line);
            line = console.nextLine();
        }
        Pattern regex = Pattern.compile("(" + formattedKey + ")(.{0,50}?)(\\1)");
        Matcher m = regex.matcher(sb.toString());
        while (m.find()) {
            String lineToPrint = m.group(2);
            if(!lineToPrint.isEmpty()) {
                System.out.println(lineToPrint);
            }
        }
        System.out.println(formattedKey);
    }
}


