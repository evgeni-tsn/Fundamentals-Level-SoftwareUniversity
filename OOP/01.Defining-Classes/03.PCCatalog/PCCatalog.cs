using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.PCCatalog
{
    class PCCatalog
    {
        static void Main(string[] args)
        {
            Components vga = new Components("VGA", "Intel HD Graphics 4400", 256.6M);
            Components vga2 = new Components("VGA", "Intel HD Graphics 5000", 306.6M);
            Components ssd = new Components("SSD 250GB", "Samsung 850 EVO", 207.9M);
            Components ssd2 = new Components("SSD 120GB", "A-Data Pro SP920", 114.64M);
            Components ram = new Components("RAM", "Мноо бърза!", 199.89M);
            Components cpu = new Components("Processor", "Intel Core i5", 399.52M);
            Components cpu2 = new Components("Processor", "Intel Core i7", 499.02M);
            Components kb = new Components("Keyboard", "Подарък!", 0M);

            List<Computer> computers = new List<Computer>()
            {
                new Computer("Dell", cpu, ssd, kb),
                new Computer("Alienware", cpu2, ssd2, vga),
                new Computer("HP", ram, vga2, kb),
                new Computer("Apple", cpu, kb),
            };

            computers
                 .OrderBy(computer => computer.Price)
                 .ToList()
                 .ForEach(Console.WriteLine);
        }
    }
}
