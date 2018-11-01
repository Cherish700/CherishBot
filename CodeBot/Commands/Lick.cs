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
    public class Lick : ModuleBase<SocketCommandContext>
    {
        private static string[] _imagePaths = new[]
        {
              "http://i.imgur.com/TyvSfsw.gif",
                "http://giphy.com/gifs/the-simpsons-getting-high-toad-licking-yFoNHwltDMG7m",
                "https://detarame.files.wordpress.com/2008/10/kannagi4-4.jpg",
                "http://s3.narvii.com/image/dzbohge5zdqfdj5aknsppsqnoxvdxehh_hq.jpg",
        };

        [Command("Lick")]
        public async Task CommandAsync(SocketGuildUser user)
        {
            // using a new instance of the Random class we randomize a path with an index from 0 to x - 1, where x is the amount of paths in the array 
            var image = _imagePaths[new Random().Next(_imagePaths.Length)];

            // we send the image
            await ReplyAsync($"{user.Mention} Mmm...Yummy...♥ {image}");
        }
    }

}