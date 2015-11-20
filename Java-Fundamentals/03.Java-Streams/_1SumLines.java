import java.io.*;

public class _1SumLines {
    //Write a program that reads a text file and prints on the console the sum
    //of the ASCII symbols of each of its lines.
    //Use BufferedReader in combination with FileReader.

    public static void main(String[] args) {
        try(BufferedReader fileReader = new BufferedReader(new InputStreamReader(new FileInputStream("res/1.SumLines.txt")));
        ){
            while (true){
                String line = fileReader.readLine();
                if (line == null) break;
                char[] chars = line.toCharArray();
                int sumOfLine = 0;
                for (char ch: chars){
                    sumOfLine += (int)ch;
                }
                System.out.println(sumOfLine);
            }
        }
        catch (IOException ioex){
            System.err.println("File not found.");
        }
  }
}
