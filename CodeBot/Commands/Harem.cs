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
    public class Harem : ModuleBase<SocketCommandContext>
    {
        private static string[] _imagePaths = new[]
        {
               "https://cdn.discordapp.com/attachments/294945693812916224/296699518584619010/Harem.jpg",
                "http://2.bp.blogspot.com/--AYgIPlDwcs/VT1SZLGyFNI/AAAAAAAAY4Q/NhpraKHc2Ug/s1600/harem-hentai-pics%2B(2).jpg",
                "http://i968.photobucket.com/albums/ae167/rosa7261/image00185_zpsd1de9374.jpg",
                "https://cdnio.luscious.net/905/lusciousnet_sample_6359eed1a0ce6838_649905871.jpg",
                "http://simg4.gelbooru.com//images/13/50/1350d0b7844112a0cf36521f9f34eb23.png",
                "http://68.media.tumblr.com/093403af4aa4a821fd9208cfab420820/tumblr_mz7ijqlrDy1s0sk8ho1_400.gif",
        };

        [Command("Harem")]
        public async Task CommandAsync(SocketGuildUser user)
        {
            // using a new instance of the Random class we randomize a path with an index from 0 to x - 1, where x is the amount of paths in the array 
            var image = _imagePaths[new Random().Next(_imagePaths.Length)];

            // we send the image
            await ReplyAsync($"{user.Mention} Harem Sex ~ ♥{image}");
        }
    }

}