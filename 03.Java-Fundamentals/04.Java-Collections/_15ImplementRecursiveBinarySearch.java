import java.util.Arrays;
import java.util.Scanner;
import java.util.stream.Stream;

public class _15ImplementRecursiveBinarySearch {
//Binary search is an algorithm that works on already sorted arrays.
//Basically, it goes to the middle element and checks it has to continue searching to the left, or to the right.
//Return the index of the element, or -1, if the element is not found.

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        Integer searchedNumber = scanner.nextInt();
        scanner.nextLine();
        int[] arrayOfNumbers = Stream.of(scanner.nextLine().split("\\s+")).mapToInt(Integer::parseInt).toArray();
        Arrays.sort(arrayOfNumbers);
        System.out.println(binarySearchImplementation(arrayOfNumbers,0,arrayOfNumbers.length-1,searchedNumber));

    }
    private static int binarySearchImplementation(int[] array,int first,int last,int searchedValue){
        if(last<first){
            return -1;
        }
        int middle = (first+last) >> 1;
        if(array[middle]>searchedValue){
            return binarySearchImplementation(array,first,middle-1,searchedValue);
        }else if(array[middle]<searchedValue){
            return  binarySearchImplementation(array,middle+1,last,searchedValue);
        }else{
            return middle;
        }
    }
}
