import java.io.*;
import java.util.ArrayList;

public class _5SaveAnArrayListOfDoubles {
//Write a program that saves and loads the information from an ArrayList to a file using
//ObjectInputStream, ObjectOutputStream. Set the name of the new file as elements.list
    public static void main(String[] args)throws IOException, ClassNotFoundException {
        ObjectOutputStream oos = new ObjectOutputStream( new FileOutputStream(
                "res/elements.list"));
        ArrayList<Double> elements = new ArrayList<>();
        elements.add(42.23);
        elements.add(2.60);
        elements.add(3.16);
        oos.writeObject(elements);
        oos.flush();
        ObjectInputStream ois = new ObjectInputStream(
                new FileInputStream("res/elements.list"));
        System.out.println(ois.readObject());
        ois.close();
    }
}
