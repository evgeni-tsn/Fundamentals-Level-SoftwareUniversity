using System;

class LastDigitOfNums
{
    //Write a method that returns the last digit of a given integer as an English word. 
    //Test the method with different input values. Ensure you name the method properly.
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        Console.WriteLine(GetLastDigitAsWord(num));
    }

    static string GetLastDigitAsWord(int number)
    {
        number = number%10;
        string numberToStr = number.ToString();
        switch (number)
        {
            case 1:
                numberToStr = "one";
                break;
            case 2:
                numberToStr = "two";
                break;
            case 3:
                numberToStr = "three";
                break;
            case 4:
                numberToStr = "four";
                break;
            case 5:
                numberToStr = "five";
                break;
            case 6:
                numberToStr = "six";
                break;
            case 7:
                numberToStr = "seven";
                break;
            case 8:
                numberToStr = "eight";
                break;
            case 9:
                numberToStr = "nine";
                break;
            case 0:
                numberToStr = "zero";
                break;
        }
        return numberToStr;
    }
    
}
