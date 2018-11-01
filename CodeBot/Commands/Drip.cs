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
    public class Drip : ModuleBase<SocketCommandContext>
    {
        private static string[] _imagePaths = new[]
        {
             "http://simg4.gelbooru.com//images/b3/d9/b3d911b1879d180eb6f3b549f8ac5961.jpg?3261060",
                "https://i.imgur.com/jd0e3cT.jpg",
                "http://68.media.tumblr.com/5864904a5ff85391f538bc4cefea66a1/tumblr_o5m9ua38fF1rf3077o1_1280.jpg",
                "http://68.media.tumblr.com/9fef8de963c1fea59e721a00b23c9d02/tumblr_n1k1uoLQsM1rbac7oo1_500.jpg",
                "http://simg4.gelbooru.com//samples/56/94/sample_56948ea078ec65961889e9444fb8c0d6.jpg?3188019",
                "https://cdn.discordapp.com/attachments/144318439639482368/241554341394251776/unknown.png",
                "http://gelbooru.com//images/0a/75/0a758e6e3ff1cc06889bec4628d64942.jpg?3364331",
                "https://cdn.discordapp.com/attachments/271469081721438212/300436166879084544/tumblr_o2n7iih80L1v59icgo8_500.gif",
        };

        [Command("Drip")]
        public async Task CommandAsync(SocketGuildUser user)
        {
            // using a new instance of the Random class we randomize a path with an index from 0 to x - 1, where x is the amount of paths in the array 
            var image = _imagePaths[new Random().Next(_imagePaths.Length)];

            // we send the image
            await ReplyAsync($"{user.Mention} I'm...full....♥ {image}");
        }
    }

}