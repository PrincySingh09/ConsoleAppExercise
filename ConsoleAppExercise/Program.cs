using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string choice;
            LargeDataCollection largeData = new LargeDataCollection();

            do
            {
                Console.WriteLine("Enter the Operations: ");
                Console.WriteLine("1. Add Player \n 2. Remove Player \n 3. Search Player \n " +
                    " 4.Show All Player");
                int opt = int.Parse(Console.ReadLine());

                switch (opt)
                {
                    case 1:
                        {
                            Console.WriteLine("Enter the name of player want to Add: ");
                            string name = Console.ReadLine();

                            largeData.Add(name);
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Enter the name of player want to Remove: ");
                            string name = Console.ReadLine();

                            largeData.Remove(name);
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Enter the name of player want to Search: ");
                            string name = Console.ReadLine();

                            largeData.Search(name);
                            break;
                        }
                    case 4:
                        {
                            largeData.DisplayAll();
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Invalid Input!");
                            break;
                        }
                }
                Console.WriteLine("Want to go again (Press y):");
                choice = Console.ReadLine().ToLower();
            } while (choice == "y");

            Console.WriteLine("All Data has been Disposed");
            largeData.Dispose();

            Console.ReadKey();

        }
    }
}