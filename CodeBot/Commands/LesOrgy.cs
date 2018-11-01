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
    public class LesOrgy : ModuleBase<SocketCommandContext>
    {
        private static string[] _imagePaths = new[]
        {
               "https://pbs.twimg.com/media/BiQGljZCYAEEcWC.jpg",
                "https://cdn.discordapp.com/attachments/294945693812916224/296654473814867968/Lesbians_Orgy.jpg",
                "https://pbs.twimg.com/media/CM4XJMjW8AAgoYT.png",
                "http://i39.tinypic.com/dy0yev.jpg",
                "https://68.media.tumblr.com/d989df35dc7a8fb38b75fd7e82d6d212/tumblr_nnd1iieML01ts2cfmo4_540.gif",
        };

        [Command("LesOrgy")]
        public async Task CommandAsync(SocketGuildUser user)
        {
            // using a new instance of the Random class we randomize a path with an index from 0 to x - 1, where x is the amount of paths in the array 
            var image = _imagePaths[new Random().Next(_imagePaths.Length)];

            // we send the image
            await ReplyAsync($"{user.Mention} Group Sex ~ ♥{image}");
        }
    }

}