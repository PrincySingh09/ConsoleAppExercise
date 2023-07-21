using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class LargeDataCollection : IDisposable
    {
        private List<string> playerList = new List<string>();
        int playerCount;
        bool disposedValue = false;

        public LargeDataCollection()
        {
            Console.WriteLine("Enter the Number of Players Details you want to Enter: ");
            playerCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < playerCount; i++)
            {
                playerList.Add(Console.ReadLine());
            }
        }

        public void Add(string pName)
        {
            playerList.Add(pName);
            playerCount++;
        }

        public void Remove(string pName)
        {
            int index = playerList.IndexOf(pName);
            if (index != -1) { playerList.Remove(pName); }
            else
            {
                Console.WriteLine("Player Name is not in List!");
            }

        }

        public void Search(string pName)
        {
            int index = playerList.IndexOf(pName);
            if (index == -1)
            {
                Console.WriteLine("Player is not in List!");
            }
            else
            {
                Console.WriteLine("Player is in the list at index {0}", index);
            }
        }

        public void DisplayAll()
        {
            Console.WriteLine("All Player List as follows:");
            foreach (var player in playerList)
            {
                Console.WriteLine(player);
            }
        }

        public virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    playerCount = 0;
                }
                playerList = null;
                disposedValue = true;
                Console.WriteLine($"The PlayerList has been disposed");
            }
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}