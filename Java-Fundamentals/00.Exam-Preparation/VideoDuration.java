package Problem1;

import java.util.Scanner;

public class VideoDuration {
    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        int hours = 0;
        int minutes = 0;
        String line = console.nextLine();
        while (!line.equals("End")){
            String[] parts = line.split(":");
            int currHours = Integer.parseInt(parts[0]);
            int currMinutes = Integer.parseInt(parts[1]);

            minutes += currMinutes;
            while (minutes>=60){
                hours++;
                minutes-=60;
            }
            hours+=currHours;

            line = console.nextLine();
        }
        if (minutes >= 0 && minutes <= 9) {
            System.out.printf("%d:0%d",hours,minutes);
        }else{
            System.out.printf("%d:%d",hours,minutes);
        }
    }
}
