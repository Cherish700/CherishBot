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
    public class Yuri : ModuleBase<SocketCommandContext>
    {
        private static string[] _imagePaths = new[]
        {
               "https://cdn.discordapp.com/attachments/294945693812916224/296426423336566784/IMG_20170329_073226.jpg",
                "http://simg4.gelbooru.com//images/c1/47/c1473a80af938b14cb4c41ba6720b512.jpg?737172",
                "https://gelbooru.com//images/13/ca/13caae117979aa60e234996a55e08ee3.jpg",
                "https://gelbooru.com//images/70/0c/700c379447f0ed7769eb9b9ed521e06a.png",
                "https://cdn.discordapp.com/attachments/294945693812916224/296378783085232128/Yuri.jpg",
                "http://gelbooru.com//images/b1/99/b1992e4b09ff1a188f7f5a55dcebefa1.gif?2264228",
                "http://68.media.tumblr.com/f2ee8ddf6fe6ac2d17d6db4ec2c111a1/tumblr_n36nju0ToR1s0sk8ho1_500.gif",
                "http://68.media.tumblr.com/d158ec0e5fd35b577885c33b6eb7c11d/tumblr_mne3acbCfd1s0sk8ho1_500.gif",
        };

        [Command("Yuri")]
        public async Task CommandAsync(SocketGuildUser user)
        {
            // using a new instance of the Random class we randomize a path with an index from 0 to x - 1, where x is the amount of paths in the array 
            var image = _imagePaths[new Random().Next(_imagePaths.Length)];

            // we send the image
            await ReplyAsync($"{user.Mention} Girls just wanna have fun~ ♥{image}");
        }
    }

}