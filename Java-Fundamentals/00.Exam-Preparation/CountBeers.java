package Problem1;

import java.util.Scanner;
import java.util.zip.Inflater;

public class CountBeers {
    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        int beers = 0;
        int stacks = 0;
        String line = console.nextLine();
        while (!line.equals("End")){
            String[] parts = line.split(" ");
            int count = Integer.parseInt(parts[0]);
            String type = parts[1];

            if (type.equals("beers")){
                beers+=count;
                while (beers>19){
                    stacks++;
                    beers -=20;
                }
            }
            else if(type.equals("stacks")){
                stacks+=count;
            }
            count=0;
            line = console.nextLine();
        }
        System.out.printf("%d stacks + %d beers",stacks,beers);
    }
}
