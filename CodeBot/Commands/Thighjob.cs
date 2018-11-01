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
    public class Thighjob : ModuleBase<SocketCommandContext>
    {
        private static string[] _imagePaths = new[]
        {
               "https://68.media.tumblr.com/0ec3d0956f4e390d51b8284cff1d96a8/tumblr_nvzpks3yws1uxrq0so1_1280.jpg",
                "https://i7a8a9b6.ssl.hwcdn.net/toons-empire.com/upload/originals/4e/a/c/4eac27aab4323a05864901bdf229e36c.jpg",
                "https://gelbooru.com/images/9c/d4/9cd49d7dbb510186b96af954e5cddeb8.webm",
                "https://simg4.gelbooru.com//images/bb/ad/bbada3be421a00a07454900f22c47805.jpeg",
                "https://imgur.com/FSsMvZ9",
        };

        [Command("Thighjob")]
        public async Task CommandAsync(SocketGuildUser user)
        {
            // using a new instance of the Random class we randomize a path with an index from 0 to x - 1, where x is the amount of paths in the array 
            var image = _imagePaths[new Random().Next(_imagePaths.Length)];

            // we send the image
            await ReplyAsync($"{user.Mention} How do you like it between my thighs? ♥ {image}");
        }
    }

}