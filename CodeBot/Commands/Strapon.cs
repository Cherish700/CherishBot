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
    public class Strapon : ModuleBase<SocketCommandContext>
    {
        private static string[] _imagePaths = new[]
        {
              "https://cdnio.luscious.net/55/lusciousnet_strapon-158_123275660.640x0.jpeg",
                "https://encrypted-tbn2.gstatic.com/images?q=tbn:ANd9GcTjW1B6NK-caPYIzup264o68VH3Jv_YSTZ1jKsx4aMecpib4Pc3aA",
                "https://cdnio.luscious.net/714/lusciousnet_girl-on-girl-lesbian-yu_1876792102.640x0.jpg",
                "http://68.media.tumblr.com/45ea5d405a81f964a1569ddfc02f41db/tumblr_nqxy20K01P1sl78mqo1_1280.jpg",
                "http://68.media.tumblr.com/4118b5ff131b1b199b6d11a6f1dfe052/tumblr_o5udvoieEL1ugp8r6o1_250.jpg",
                "http://68.media.tumblr.com/4cebafc88096535f35d26e5a3f2dd59c/tumblr_mnfyucc86O1s0sk8ho1_500.gif",
                "http://www.animated-gifs.eu/category_xxx/phone-640x480-hentai/0079.gif",
        };

        [Command("Strapon")]
        public async Task CommandAsync(SocketGuildUser user)
        {
            // using a new instance of the Random class we randomize a path with an index from 0 to x - 1, where x is the amount of paths in the array 
            var image = _imagePaths[new Random().Next(_imagePaths.Length)];

            // we send the image
            await ReplyAsync($"{user.Mention} How do you like this dick huh, you fucking slut ? {image}");
        }
    }

}