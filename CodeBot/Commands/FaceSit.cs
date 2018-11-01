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
    public class FaceSit : ModuleBase<SocketCommandContext>
    {
        private static string[] _imagePaths = new[]
        {
             "https://cdn.discordapp.com/attachments/294945693812916224/296043263322882049/tumblr_oi3yzd3ibn1vpe4noo1_540.gif",
                "http://gelbooru.com//samples/33/65/sample_336597e9b0d3664dabd13773d5407c88.jpg?3394786",
                "http://68.media.tumblr.com/f78768be4d29d7d64752c66620b3cfb2/tumblr_ngfowfmfrx1u5zs3co1_1280.jpg",
                "http://gelbooru.com//samples/ad/81/sample_ad814c13a8b0e74cd5b5a740a9a0eaf9.jpg?3239699",
                "http://68.media.tumblr.com/14fdb63db1a58448510b1c9c47f9d774/tumblr_oadyfzBOtA1th4sa0o1_r1_1280.png",
        };

        [Command("FaceSit")]
        public async Task CommandAsync(SocketGuildUser user)
        {
            // using a new instance of the Random class we randomize a path with an index from 0 to x - 1, where x is the amount of paths in the array 
            var image = _imagePaths[new Random().Next(_imagePaths.Length)];

            // we send the image
            await ReplyAsync($"{user.Mention} I'll sit on your face! P-Perv... ♥ {image}");
        }
    }

}