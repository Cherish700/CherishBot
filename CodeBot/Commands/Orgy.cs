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
    public class Orgy : ModuleBase<SocketCommandContext>
    {
        private static string[] _imagePaths = new[]
        {
               "http://cdn1.zzcartoon.com/contents/videos_screenshots/7000/7196/preview.mp4.jpg",
                "https://gelbooru.com//samples/27/4a/sample_274a06c98b6e4eb122d074897389da8a.jpg",
                "https://gelbooru.com//images/10/ae/10ae9351c9dfd394b94097147ed5743d.jpeg",
                "http://i1.nuttit.com/hentai/Fate_Orgy__Fate_Zero__76812623.jpg",
                "http://simg4.gelbooru.com//samples/3e/44/sample_3e447c2284be47a51a3d21a84460e155.jpg",
                "http://cdn1.zzcartoon.com/contents/videos_screenshots/4000/4168/preview.mp4.jpg",
                "http://x.imagefapusercontent.com/u/KeesSteeghs/6415997/1898361136/dngnrnp.jpeg",
                "http://x.imagefapusercontent.com/u/skylarks25/6786225/1411952148/Shakugan_no_Shana_03c3762ad6887b75c17b4c0d8f826bca1b8c5466.jpg",
        };

        [Command("Orgy")]
        public async Task CommandAsync(SocketGuildUser user)
        {
            // using a new instance of the Random class we randomize a path with an index from 0 to x - 1, where x is the amount of paths in the array 
            var image = _imagePaths[new Random().Next(_imagePaths.Length)];

            // we send the image
            await ReplyAsync($"{user.Mention} Group Sex ~ ♥{image}");
        }
    }

}