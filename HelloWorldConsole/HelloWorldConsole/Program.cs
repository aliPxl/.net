using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string naam;
            int getal;
            //inlezen
            Console.Write("geef een naam : ");
            naam = Console.ReadLine();
            Console.Write("geef een getal: ");
            getal =int.Parse( Console.ReadLine());
            Console.Write("------------");
            Console.Write($"Naam: {naam}\t Getal: {getal}. ");
            Console.Write("druk op enter om af te sluiten");
            Console.ReadLine();
        }
    }
}
