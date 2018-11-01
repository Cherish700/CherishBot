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
    public class Buttjob : ModuleBase<SocketCommandContext>
    {
        private static string[] _imagePaths = new[]
        {
              "http://gelbooru.com//images/1e/84/1e84f926156021ef7b6923801e507540.gif?3380912",
                "http://gelbooru.com//images/05/7a/057ac8596c7b7175d64dd102d4425537.gif?2959456",
                "https://cdn.discordapp.com/attachments/277010998886400010/295595180973752320/31cd24fc5c4bf373729e7ffd22ae31a9.png",
                "http://gelbooru.com//images/a1/11/a111f685bd2762c3c56f3aadc303ecb7.gif?3160910",
                "https://cdn.discordapp.com/attachments/271469081721438212/300432606925684756/unknown.png",
        };

        [Command("Buttjob")]
        public async Task CommandAsync(SocketGuildUser user)
        {
            // using a new instance of the Random class we randomize a path with an index from 0 to x - 1, where x is the amount of paths in the array 
            var image = _imagePaths[new Random().Next(_imagePaths.Length)];

            // we send the image
            await ReplyAsync($"{user.Mention} *Rub rub rub* ♥ {image}");
        }
    }

}