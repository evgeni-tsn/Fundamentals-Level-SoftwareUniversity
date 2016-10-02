package Problem1;

import java.util.Scanner;

public class TinySporebar {

    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        int health = 5800;
        int glowcaps = 0;
        int neededGlowcaps = 30;
        String line = console.nextLine();
        while (!(line.equals("Sporeggar"))){
            Character rowValue = line.charAt(line.length() - 1);
            String str = String.valueOf(rowValue);
            Integer lastDigit = Integer.parseInt(str);
            char[] enemies = line.substring(0, line.length()-1).toCharArray();
            for (char enemy:enemies){
                if (enemy=='L'){
                    health += 200;
                }
                else {
                    int getValueOfChar = (int) enemy;
                    health-=getValueOfChar;
                }
            }
            if (health<1){
                break;
            }
            glowcaps += lastDigit;
            line = console.nextLine();
        }
        if (health>0){
            if (glowcaps>=neededGlowcaps){
                System.out.println("Health left: "+health);
                System.out.println("Bought the sporebat. Glowcaps left: " + (glowcaps-neededGlowcaps));
            }
            else{
                System.out.println("Health left: "+health);
                System.out.println("Safe in Sporeggar, but another "+ (neededGlowcaps-glowcaps) +" Glowcaps needed.");
            }
        }
        else {
            System.out.println("Died. Glowcaps: "+glowcaps);
        }
    }
}
