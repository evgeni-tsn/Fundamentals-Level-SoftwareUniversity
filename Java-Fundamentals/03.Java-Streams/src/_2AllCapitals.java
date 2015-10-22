import java.io.*;

public class _2AllCapitals {
    //Write a program that reads a text file and changes the casing of all letters to upper.
    //The file should be overwritten. Use BufferedReader, FileReader, FileWriter, and PrintWriter.

    public static void main(String[] args) {
        try (
                BufferedReader fr = new BufferedReader(
                                new FileReader("res/2.AllCapitals-input.txt"));
                BufferedWriter fw =
                        new BufferedWriter(
                                new FileWriter("res/2.AllCapitals-output.txt"));
                )
        {
            while (true){
            String line = fr.readLine();
            if (line == null)break;
                fw.write(line.toUpperCase());
                fw.newLine();
            }
            System.out.println("Done");
        } catch (IOException ioex){
            System.err.println("File not found. Check out file: 2.AllCapitals-output.txt");
        }
    }
}
