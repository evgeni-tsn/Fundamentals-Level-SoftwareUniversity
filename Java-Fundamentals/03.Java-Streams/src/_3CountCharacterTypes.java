import java.io.*;

public class _3CountCharacterTypes {

    //Write a program that reads a list of words from the file words.txt
    //and finds the count of vowels (гласни букви), consonants (съгласни)
    //and other punctuation marks. Since English is a bit tricky, assume
    //that a, e, i, o, u are vowels and all others are consonants.
    //Punctuation marks are (!,.?). Do not count whitespace.
    //Write the results in file count-chars.txt.

    public static void main(String[] args) {
        try (
                BufferedReader fr = new BufferedReader(
                        new FileReader("res/3.CountCharTypes-words.txt"));
                BufferedWriter fw =
                        new BufferedWriter(
                                new FileWriter("res/count-chars.txt"));
        )
        {

            int volewsCounter = 0;
            int consonantsCounter = 0;
            int punctuationCounter = 0;
            while (true){
                String line = fr.readLine();
                if (line == null) break;
                char[] chars = line.toCharArray();

                for (char letter: chars){
                    if (letter != ' '){
                    switch (letter){
                        case 'a':
                            volewsCounter++;
                            break;
                        case 'e':
                            volewsCounter++;
                            break;
                        case 'i':
                            volewsCounter++;
                            break;
                        case 'o':
                            volewsCounter++;
                            break;
                        case 'u':
                            volewsCounter++;
                            break;
                        case '!':
                            punctuationCounter++;
                            break;
                        case '.':
                            punctuationCounter++;
                            break;
                        case ',':
                            punctuationCounter++;
                            break;
                        case '?':
                            punctuationCounter++;
                            break;
                        default:
                            consonantsCounter++;
                            break;
                    }
                    }
                }
            }
            fw.write("Vowels: "+volewsCounter);
            fw.newLine();
            fw.write("Consonants: "+consonantsCounter);
            fw.newLine();
            fw.write("Punctuation: "+punctuationCounter);
            fw.newLine();
            System.out.println("Done. Check out file: count-chars.txt");
        } catch (IOException ioex){
            System.err.println("File not found.");
        }
    }
}
