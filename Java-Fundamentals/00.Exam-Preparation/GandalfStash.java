package Problem1;

import java.util.Scanner;

public class GandalfStash {

    public static void main(String[] args) {
        //da si znaish

        Scanner console = new Scanner(System.in);
        Integer firstMood = Integer.parseInt(console.nextLine());
        String[] foods = console.nextLine().split("[^A-Za-z]+");
        for (int i = 0; i < foods.length; i++) {
            switch (foods[i].toLowerCase()){
                case "cram":
                    firstMood+=2;
                    break;
                case "lembas":
                    firstMood+=3;
                    break;
                case "apple":
                    firstMood+=1;
                    break;
                case "melon":
                    firstMood+=1;
                    break;
                case "honeycake":
                    firstMood+=5;
                    break;
                case "mushrooms":
                    firstMood-=10;
                    break;
                default:
                    firstMood-=1;
                    break;
            }
        }
        System.out.println(firstMood);
        if (firstMood <-5){
            System.out.println("Angry");
        }
        else if(firstMood>=-5 && firstMood<0){
            System.out.println("Sad");
        }
        else if(firstMood>=0 && firstMood<15){
            System.out.println("Happy");
        }
        else if(firstMood>15){
            System.out.println("Special JavaScript mood");
        }
    }
}
