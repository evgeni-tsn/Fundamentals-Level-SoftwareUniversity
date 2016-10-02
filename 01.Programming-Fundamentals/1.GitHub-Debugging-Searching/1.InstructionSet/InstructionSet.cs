using System;

class InstructionSet
{
    /* You can check this problem in the judge contest:
    * https://judge.softuni.bg/Contests/Practice/Index/203#0 */
    static void Main()
    {
        string input = Console.ReadLine();
        long result = 0;

        while (input != "END")
        {
            string[] codeArgs = input.Split(' ');

            switch (codeArgs[0])
            {
                case "INC":
                    {
                        long operandOne = long.Parse(codeArgs[1]);
                        result = operandOne;
                        result++;
                        break;
                    }
                case "DEC":
                    {
                        long operandOne = long.Parse(codeArgs[1]);
                        result = operandOne;
                        result--;
                        break;
                    }
                case "ADD":
                    {
                        long operandOne = long.Parse(codeArgs[1]);
                        long operandTwo = long.Parse(codeArgs[2]);
                        result = (long)operandOne + operandTwo;
                        break;
                    }
                case "MLA":
                    {
                        long operandOne = long.Parse(codeArgs[1]);
                        long operandTwo = long.Parse(codeArgs[2]);
                        result = (long)(operandOne * operandTwo);
                        break;
                    }
            }
            input = Console.ReadLine();
            Console.WriteLine(result);
        }
    }
}