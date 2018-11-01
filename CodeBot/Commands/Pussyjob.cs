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
    public class Pussyjob : ModuleBase<SocketCommandContext>
    {
        private static string[] _imagePaths = new[]
        {
              "https://cdnio.luscious.net/shiningvoid/945/lusciousnet_lusciousnet_92f3539ef9a574298b5a369732e775f0_295181982.315x0.jpg",
                "http://c3.nuttit.com/Cache/GetImage?id=jnN3Cc8.gif",
                "http://x.imagefapusercontent.com/u/bobdole150/4690030/421509323/Faces_587568027.gif",
                "http://img0.thatpervert.com/pics/post/-pussyjob--hentai-2171942.gif",
                 "https://gfycat.com/gifs/detail/exhaustedregularhellbender",
                 "https://gfycat.com/gifs/detail/regularunripeindianelephant",
                 "https://gfycat.com/gifs/detail/diligentevergreenbighornsheep",
                 "https://gfycat.com/gifs/detail/defensiveinsistentdotterel",
        };

        [Command("Pussyjob")]
        public async Task CommandAsync(SocketGuildUser user)
        {
            // using a new instance of the Random class we randomize a path with an index from 0 to x - 1, where x is the amount of paths in the array 
            var image = _imagePaths[new Random().Next(_imagePaths.Length)];

            // we send the image
            await ReplyAsync($"{user.Mention} Does my pussy feels good? ♥ {image}");
        }
    }

}