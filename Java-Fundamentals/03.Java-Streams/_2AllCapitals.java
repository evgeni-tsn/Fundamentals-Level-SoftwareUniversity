import java.io.*;

public class _2AllCapitals {
    //Write a program that reads a text file and changes the casing of all letters to upper.
    //The file should be overwritten. Use BufferedReader, FileReader, FileWriter, and PrintWriter.

    public static void main(String[] args) {
        StringBuilder sb = new StringBuilder();
        try (
                BufferedReader fr = new BufferedReader(
                                new FileReader("res/2.AllCapitals-input.txt"));

                )
        {

            while (true){
            String line = fr.readLine();
            if (line == null)break;
                sb.append(line.toUpperCase()+"\r\n");
            }
            System.out.println("Done");
        } catch (IOException ioex){
            System.err.println("File not found. Check out file: 2.AllCapitals-output.txt");
        }
        try (BufferedWriter fw =
                     new BufferedWriter(
                             new PrintWriter("res/2.AllCapitals-input.txt"))){
            fw.write(sb.toString());
        }
        catch (IOException ioex){

        }
    }
}
