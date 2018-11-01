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
    public class Bondage : ModuleBase<SocketCommandContext>
    {
        private static string[] _imagePaths = new[]
        {
              "http://simg4.gelbooru.com//samples/c8/44/sample_c844e3ed430bc19252f9b9450ad2260c.jpg?2648906",
                "http://gelbooru.com//samples/7e/99/sample_7e99d25108426941a46fb702cffadd1c.jpg?3146238",
                "http://gelbooru.com//samples/e1/0a/sample_e10ab95ab4513941d862273ad9a019f1.jpg?3320480",
                "http://gelbooru.com//images/7c/bc/7cbcc3f758b9cfc6842eddf1b5b87e06.png?3188047",
                "http://gelbooru.com//samples/10/df/sample_10dfb3f2e164280833ab191aad0dae88.jpg?3391236",
                "http://gelbooru.com//samples/a9/fd/sample_a9fd49e4798686cea4205ec8c3e40522.jpg?3494568",
        };

        [Command("Bondage")]
        public async Task CommandAsync(SocketGuildUser user)
        {
            // using a new instance of the Random class we randomize a path with an index from 0 to x - 1, where x is the amount of paths in the array 
            var image = _imagePaths[new Random().Next(_imagePaths.Length)];

            // we send the image
            await ReplyAsync($"{user.Mention} You can't escape ~ {image}");
        }
    }

}