import javax.xml.parsers.FactoryConfigurationError;
import java.util.Scanner;

public class _16CalculateFactorialRecursively {
    //Write a program that recursively calculates factorial.

    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        int num = console.nextInt();
        System.out.println(Factorial(num));
    }
    public static long Factorial(int n)
    {
        if (n == 0)
            return 1;
        else
            return n * Factorial(n-1);
    }
}
