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
    public class Finger : ModuleBase<SocketCommandContext>
    {
        private static string[] _imagePaths = new[]
        {
                "http://simg4.gelbooru.com//images/64/08/6408b6e9d07687d8f6fd640bcf34ce6c.gif?3361486",
                "http://68.media.tumblr.com/13108cbe4c9a7c0591b2129afafe5b17/tumblr_ohyh9hD9YI1uwn515o1_500.png",
                "http://68.media.tumblr.com/6d1d98816b0e5d7c0e091fb7a5809864/tumblr_nsrp4oeGBX1t99d7po1_400.gif",
                "https://gelbooru.com//images/70/0c/700c379447f0ed7769eb9b9ed521e06a.png",
                "https://gelbooru.com//images/13/ca/13caae117979aa60e234996a55e08ee3.jpg",
                "https://68.media.tumblr.com/13a4b1d357d00c75286f2fbf64a428b8/tumblr_nztzlvmE0v1toy0ydo1_400.gif",
                "https://68.media.tumblr.com/20e28a3a15879698997abc03336d1b7c/tumblr_mvfyf12TGw1smtpyco1_500.gif",
                "http://www.animated-gifs.eu/category_xxx/phone-640x480-hentai/0155.gif",
                "http://www.animated-gifs.eu/category_xxx/phone-640x480-hentai/0163.gif",
        };

        [Command("Finger")]
        public async Task CommandAsync(SocketGuildUser user)
        {
            // using a new instance of the Random class we randomize a path with an index from 0 to x - 1, where x is the amount of paths in the array 
            var image = _imagePaths[new Random().Next(_imagePaths.Length)];

            // we send the image
            await ReplyAsync($"{user.Mention} :middle_finger::skin-tone-2: {image}");
        }
    }

}