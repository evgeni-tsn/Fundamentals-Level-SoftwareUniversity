package Problem1;

import java.util.Arrays;
import java.util.Scanner;
import java.util.stream.Collectors;

/**
 * Created by Evgeni on 11/1/2015.
 */
public class Enigma {
    public static void main(String[] args) {
        //X = k + m
        //X - ASCII code for dec letter
        //k - encrypted char
        //m - int of half lenght w/o spaces and nums
        Scanner console = new Scanner(System.in);
        StringBuilder sb = new StringBuilder();
        StringBuilder sb2 = new StringBuilder();
        int n = Integer.parseInt(console.nextLine());

        String line = "";
        for (int i = 0; i < n; i++) {
            line = console.nextLine();
            String[] getM = line.split("\\s+|\\d+");
            for (int j = 0; j < getM.length; j++) {
                sb.append(getM[j]);
            }
            int sizeM = sb.length()/2;

            for(Character ch : line.toCharArray()) {
                if (ch.equals(' ')){
                    sb2.append(' ');
                }else if(ch>='0'&&ch<='9'){
                    sb2.append(ch);
                }else{
                int getASCII = (int)ch;
                int calculated = sizeM + getASCII;
                sb2.append((char)calculated);
                }
            }


            System.out.println(sb2.toString());
            sb.setLength(0);
            sb2.setLength(0);
        }
    }
}
