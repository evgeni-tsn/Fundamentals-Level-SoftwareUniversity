import java.io.File;
import java.io.FileInputStream;
import java.io.FileOutputStream;
import java.io.IOException;

public class _4CopyJPGFile {
    //Write a program that copies the contents of a .jpg file to another using FileInputStream,
    //FileOutputStream and byte[] buffer. Set the name of the new file as my-copied-picture.jpg.

    public static void main(String[] args) {
        try
        {
            FileInputStream fis = new FileInputStream("res/original.jpg");
            FileOutputStream fos = new FileOutputStream("res/my-copied-picture.jpg");
                int currentByte = fis.read();
                while( currentByte != -1 )
                {
                    fos.write( currentByte );
                    currentByte = fis.read();
                }
        }
        catch( IOException exception )
        {
            System.err.println( "Problems with file!" );
        }
    }
}
