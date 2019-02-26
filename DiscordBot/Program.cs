using System;
using DiscordBot.Discord;
using DiscordBot.Discord.Entities;

namespace DiscordBot
{
    internal class Program
    {
        private static void Main()
        {
            Unity.RegisterTypes();
            Console.WriteLine("Hello, Discord!");

            var discordBotConfig = new RaizisBotConfig
            {
                Token = "ABC",
                SocketConfig = SocketConfig.GetDefault()
            };

            var connection = Unity.Resolve<Connection>();
        }
    }
}
