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
    public class Les3some : ModuleBase<SocketCommandContext>
    {
        private static string[] _imagePaths = new[]
        {
                "http://i.imgur.com/O3bwBv2.jpg",
                "http://hostave4.net/hpw/fhg/photo/0119picsh_dvi/02b.jpg",
                "https://cdnio.luscious.net/FullMetalPervert/277942/photo-hentai-lesbian-threesome-358670266_01B68541JT7CTBV9QK3DSBZ42C.jpg",
                "https://cdn.discordapp.com/attachments/294945693812916224/296426412489965568/IMG_20170329_073124.jpg",
                "https://cdn.discordapp.com/attachments/294945693812916224/296426400737656832/IMG_20170329_073104.jpg",
                "https://68.media.tumblr.com/719544a155fd2909181b5addc63838e1/tumblr_nwue9s7vyq1uzetcvo1_500.gif",
        };

        [Command("Les3some")]
        public async Task CommandAsync(SocketGuildUser user, SocketGuildUser user2, SocketGuildUser user3)
        {
            // using a new instance of the Random class we randomize a path with an index from 0 to x - 1, where x is the amount of paths in the array 
            var image = _imagePaths[new Random().Next(_imagePaths.Length)];

            // we send the image
            await ReplyAsync($"{user.Mention}, {user2.Mention}, {user3.Mention} It's even more fun with three!~ ♥ {image}");
        }
    }

}