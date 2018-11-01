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
    public class TeaseHim : ModuleBase<SocketCommandContext>
    {
        private static string[] _imagePaths = new[] 
        {
                "http://68.media.tumblr.com/dfcfc065ea67c0137f9f9a8dbc074350/tumblr_o2mbugUd2Q1sz111so1_540.gif",
                "http://68.media.tumblr.com/661b7dce48701d861fac342676a2ee94/tumblr_o8tzvu7Ngp1vpe4noo1_540.gif",
                "http://68.media.tumblr.com/479cf78a7a376f42450bdaff38b08309/tumblr_occjxowBvf1vpe4noo2_540.gif",
                "http://68.media.tumblr.com/61b93a56530bb2a3de6515f9fd30fd8f/tumblr_ofp29ui2Ey1sqvybwo1_1280.png",
                "http://68.media.tumblr.com/d058267f17fe8ccdf07f8be36f3339c3/tumblr_oenhj7JySE1vfn900o1_1280.jpg",
                "http://68.media.tumblr.com/33b9f41bdf6f06b9cf570fdae8bf559c/tumblr_odu1tnNRwO1th4sa0o1_1280.png",
                "https://cdn.discordapp.com/attachments/294945693812916224/296427249065000960/tumblr_o9cc1a2j7P1v5z2lfo1_500.png",
                "http://68.media.tumblr.com/bb84fe5e178d7f15dcffcaede0cc5397/tumblr_n1n5n0EKaT1s0sk8ho1_500.gif",
                "https://68.media.tumblr.com/4cabf63874225d65ded86485b80e3ac5/tumblr_o2hrxuviRa1v7dixko1_500.gif",
                "http://www.animated-gifs.eu/category_xxx/phone-640x480-hentai/0046.gif",
                "http://www.animated-gifs.eu/category_xxx/phone-640x480-hentai/0161.gif",
        };

        [Command("TeaseHim")]
        public async Task CommandAsync(SocketGuildUser user)
        {
            // using a new instance of the Random class we randomize a path with an index from 0 to x - 1, where x is the amount of paths in the array 
            var image = _imagePaths[new Random().Next(_imagePaths.Length)];

            // we send the image
            await ReplyAsync($"{user.Mention} You're so cute when I tease you~ ♥ {image}");
        }
    }
   
}