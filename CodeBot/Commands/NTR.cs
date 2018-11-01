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
    public class NTR : ModuleBase<SocketCommandContext>
    {
        private static string[] _imagePaths = new[]
        {
              "https://cdn.discordapp.com/attachments/277010998886400010/296034125159071744/ddddd0e3483ad35ef34224eeeeccd8ad.jpg",
                "http://gelbooru.com//samples/0f/49/sample_0f49c035e3bfdbbe30344c2cc240c115.jpg?2949224",
                "http://gelbooru.com//samples/07/da/sample_07da4e02884dfda1c6c3809701a7dbdc.jpg?1115153",
                "http://simg4.gelbooru.com//samples/6d/d1/sample_6dd15daa16cb75827a174d62f6a0368a.jpg?3414655",
                "http://gelbooru.com//images/db/b3/dbb3c173c2327b99dca75d28fb04e8ea.png?3180839",
                "http://gelbooru.com//images/6b/ac/6baccc2fcfe73ba38c2ba52e148a30a9.png?3180871",
                "http://gelbooru.com//samples/6e/46/sample_6e462fb369a85e68b9c87c36fea962f0.jpg?1810591",
        };

        [Command("NTR")]
        public async Task CommandAsync(SocketGuildUser user)
        {
            // using a new instance of the Random class we randomize a path with an index from 0 to x - 1, where x is the amount of paths in the array 
            var image = _imagePaths[new Random().Next(_imagePaths.Length)];

            // we send the image
            await ReplyAsync($"{user.Mention} I'm sorry, but his is so good..!~ ♥ {image}");
        }
    }

}