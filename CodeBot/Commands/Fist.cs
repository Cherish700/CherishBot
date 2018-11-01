using Discord;
using Discord.Commands;
using Discord.WebSocket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeBot
{
    public class Fist : ModuleBase<SocketCommandContext>
    {
        private static string[] _imagePaths = new[]
        {
                "http://simg4.gelbooru.com//images/ad/e1/ade1cab6989a1b42ebc3a7fc8befd14a.jpg?2209347",
                "https://cdn.discordapp.com/attachments/277010998886400010/295907231550013440/Fist1.jpg",
                "https://cdn.discordapp.com/attachments/277010998886400010/295907860603207680/Fist2.jpg",
                "https://cdnio.luscious.net/478/z14_886508784.jpg",
                "http://simg4.gelbooru.com//samples/ed/f3/sample_edf330d8ffdcf93bfe15455821466e15.jpg?3266968",
        };

        [Command("Fist")]
        public async Task CommandAsync(SocketGuildUser user)
        {
            // using a new instance of the Random class we randomize a path with an index from 0 to x - 1, where x is the amount of paths in the array 
            var image = _imagePaths[new Random().Next(_imagePaths.Length)];

            // we send the image
            await ReplyAsync($"{user.Mention} Just be glad I'm not One-Punch Man.{image}");
        }
    }

}