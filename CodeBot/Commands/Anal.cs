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
    public class Anal : ModuleBase<SocketCommandContext>
    {
        private static string[] _imagePaths = new[]
        {
              "https://cdnio.luscious.net/361/148061_547105009.315x0.jpg",
                "https://gelbooru.com//samples/3a/b8/sample_3ab8b65b275c995fd65696ba96ead977.jpg",
                "https://gelbooru.com//images/8f/69/8f696ba854bdc83420e857d85ad5debb.jpeg",
                "https://encrypted-tbn3.gstatic.com/images?q=tbn:ANd9GcSlA9sUp8ohi7JQzigqUeAO-F8fzXoirE1Frc8Um20ZsQdJbhKW",
                "http://www.animated-gifs.eu/category_xxx/phone-640x480-hentai/0125.gif",
        };

        [Command("Anal")]
        public async Task CommandAsync(SocketGuildUser user)
        {
            // using a new instance of the Random class we randomize a path with an index from 0 to x - 1, where x is the amount of paths in the array 
            var image = _imagePaths[new Random().Next(_imagePaths.Length)];

            // we send the image
            await ReplyAsync($"{user.Mention} Buttering up the good ol' pooper! ♥ {image}");
        }
    }

}