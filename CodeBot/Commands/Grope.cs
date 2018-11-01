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
    public class Grope : ModuleBase<SocketCommandContext>
    {
        private static string[] _imagePaths = new[]
        {
              "http://gelbooru.com//images/1a/06/1a06602ceab9a90449d7254926e460e1.gif?2132378",
                "https://cdnio.luscious.net/205/lusciousnet_boob-groping-and-tit-gr_1287257465.jpg",
                "http://68.media.tumblr.com/586b6c70f922cafd536ab912fbf88ab2/tumblr_n7oq6ratuq1t73f3io1_500.jpg",
                "https://cdn.discordapp.com/attachments/270502370482454530/298921996991987713/a780003b03675f7a453.jpg",
                "http://68.media.tumblr.com/f1be3243841df2c8eedb93c30106b06a/tumblr_mvxo5kGl0C1s0sk8ho1_500.gif",
                "http://68.media.tumblr.com/9265abad76e9c800d0f797c57a675e58/tumblr_mvon73Ze9X1s0sk8ho1_1280.gif",
                "http://68.media.tumblr.com/c891d295420c2af7fa70caab8ae6b54b/tumblr_mnq5zw2pSw1s0sk8ho1_500.gif",
                "https://68.media.tumblr.com/7366a6af49f8bdd4f9a0c97bbc189c45/tumblr_njbgpsWUhX1tcjldro1_1280.gif",
                "http://www.animated-gifs.eu/category_xxx/phone-640x480-hentai/0048.gif",
                "http://www.animated-gifs.eu/category_xxx/phone-640x480-hentai/0181.gif",
        };

        [Command("Grope")]
        public async Task CommandAsync(SocketGuildUser user)
        {
            // using a new instance of the Random class we randomize a path with an index from 0 to x - 1, where x is the amount of paths in the array 
            var image = _imagePaths[new Random().Next(_imagePaths.Length)];

            // we send the image
            await ReplyAsync($"{user.Mention} *Squeezes* {image}");
        }
    }

}