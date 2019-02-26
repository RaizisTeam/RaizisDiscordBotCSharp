using System;
using System.Threading.Tasks;

namespace DiscordBot
{
    internal class Program
    {
        private static void Main()
        {
            Unity.RegisterTypes();
            Console.WriteLine("Hello, Discord!");
        }
    }
}
