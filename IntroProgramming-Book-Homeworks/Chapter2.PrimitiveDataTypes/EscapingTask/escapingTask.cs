using System;
class escapingTask
{
    static void Main()
    {
        string with = "The \"use\" of quotations causes difficulties.";
        string without = @"The ""use"" of quotations causes difficulties.";
    }
}
