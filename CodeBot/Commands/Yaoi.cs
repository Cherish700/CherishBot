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
    public class Yaoi : ModuleBase<SocketCommandContext>
    {
        private static string[] _imagePaths = new[]
        {
                "https://cdnio.luscious.net/330/lusciousnet_9b3e42d20359e4bd9b743a2_1645462396.1024x0.jpeg",
                "https://cdnio.luscious.net/415/lusciousnet_08f1b87794f2f8e2f5e9d2f_1058523357.png",
                "https://cdnio.luscious.net/923/lusciousnet_48a3ad25345c5e8fd300437_735989170.jpeg",
                "https://68.media.tumblr.com/7f10be842a7a5960c87c67112b1a9606/tumblr_o6b58v1xOF1ufjp66o1_540.gif",
                "http://x.imagefapusercontent.com/u/Rotom/5940676/61922439/clo1.jpg",
                "http://x.imagefapusercontent.com/u/Rotom/5940610/99355953/ns1.jpg",
                "http://x.imagefapusercontent.com/u/Rotom/5940599/1289311714/18.jpg",
        };

        [Command("Yaoi")]
        public async Task CommandAsync(SocketGuildUser user)
        {
            // using a new instance of the Random class we randomize a path with an index from 0 to x - 1, where x is the amount of paths in the array 
            var image = _imagePaths[new Random().Next(_imagePaths.Length)];

            // we send the image
            await ReplyAsync($"{user.Mention} Mhmm...his penis feels good{image}");
        }
    }

}