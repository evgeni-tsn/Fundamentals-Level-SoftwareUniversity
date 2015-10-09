using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;

class AveLoadTimeCalc
{
    //We have a report that holds dates, web site URLs and load times (in seconds) in the same format like in the examples below. Your tasks is to calculate the average load time for each URL. Print the URLs in the same order as they first appear in the input report. Print the output in the format given below. Use double floating-point precision. 
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-US");
        Console.Write("Number of inputs: ");
        int count = int.Parse(Console.ReadLine());
        List<string> inputs = new List<string>();
        for (int i = 0; i < count; i++)
        {
            inputs.Add(Console.ReadLine());
        }
        List<string> distincts = new List<string>();
        for (int i = 0; i < inputs.Count; i++)
        {
            string[] temp = inputs[i].Split(' ');
            if (distincts.Contains(temp[2]))
            {
                continue;
            }
            else
            {
                distincts.Add(temp[2]);
            }
        }
        for (int i = 0; i < distincts.Count; i++)
        {
            double totalTime = 0d;
            double instances = 0;
            for (int j = 0; j < inputs.Count; j++)
            {
                string[] temp = inputs[j].Split(' ');
                if (temp[2] == distincts[i])
                {
                    totalTime += Convert.ToDouble(temp[3]);
                    instances++;
                }
            }
            Console.WriteLine("{0} -> {1}", distincts[i], totalTime / instances);
        }
        Console.WriteLine();
    }
}
