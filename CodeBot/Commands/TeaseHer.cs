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
    public class TeaseHer : ModuleBase<SocketCommandContext>
    {
        private static string[] _imagePaths = new[]
        {
               "http://68.media.tumblr.com/ee2f45b9c30e9fbd6c9c6a233f2b74aa/tumblr_o9lpejjNtq1uwn515o1_540.png",
                "http://68.media.tumblr.com/8c1c5731c6fd88d98f783aeb4d368c79/tumblr_nvssp5H8Fr1s27brzo1_500.png",
                "http://68.media.tumblr.com/fc1dc2f2eff833b86a1f2e2d4f100724/tumblr_ofhu66pwRy1vpe4noo1_540.gif",
                "http://68.media.tumblr.com/d99a6ae0fd90993fa2eb3f91a9427819/tumblr_oii5dkBh631vyy083o1_1280.png",
                "http://68.media.tumblr.com/effd25039de367cb6b9dbfd2ef57a122/tumblr_nwha89mOfz1tog6efo1_540.png",
                "http://i.imgur.com/UCxARvK.gif",
                "https://68.media.tumblr.com/0ddf3656f87a20f0aeba4fecce5c6fd4/tumblr_o6qqwggzPB1toy0ydo1_500.gif",
                "https://68.media.tumblr.com/34afd4a34ca90e63f0dd82ffbccfddc6/tumblr_o3pegzGnUs1v8szqxo1_500.gif",
                "http://68.media.tumblr.com/ce7ee7063d1ce152fe0f4fe8801532d8/tumblr_nyg4teur941rmzw91o1_540.gif",
                "http://68.media.tumblr.com/257ff45ca917283e004d136d192d4331/tumblr_ob87unDA8q1rkqedto1_1280.gif",
                "http://www.animated-gifs.eu/category_xxx/phone-640x480-hentai/0107.gif",
                "http://www.animated-gifs.eu/category_xxx/phone-640x480-hentai/0178.gif",
        };

        [Command("TeaseHer")]
        public async Task CommandAsync(SocketGuildUser user)
        {
            // using a new instance of the Random class we randomize a path with an index from 0 to x - 1, where x is the amount of paths in the array 
            var image = _imagePaths[new Random().Next(_imagePaths.Length)];

            // we send the image
            await ReplyAsync($"{user.Mention} You're so cute when I tease you~ :3 {image}");
        }
    }

}